using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using Newtonsoft.Json;

namespace GIAO_DIEN
{
    public partial class Form1 : Form
    {
        String Data = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            comboPort.Items.AddRange(ports);
        }
        private void comboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboPort.Text;
 
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            if (comboPort.Text == "")
            {
                MessageBox.Show("Select COM Port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show("COM Port is connected and ready for use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        serialPort1.Open();
                        //serialPort1.BaudRate = Convert.ToInt32(comboBaund.Text);
                        textBox2.BackColor = Color.Lime;
                        textBox2.Text = "Connection...";
                        comboPort.Enabled = false;//đong com
                        comboBaund.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("COM Port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
           if(comboBaund.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tốc độ baund", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    textBox2.BackColor = Color.Red;
                    textBox2.Text = "Disconnected!";
                    comboPort.Enabled = true;//đong com
                    comboBaund.Enabled = true;
                }
                else
                {
                    MessageBox.Show("COM Port is disconnected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM Port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            
            try
            {
                textBox1.Text = Data;
                var DataJson = JsonConvert.DeserializeObject<dynamic>(Data.Trim());
                textBoxND.Text = DataJson.ND;
                textBoxDA.Text = DataJson.DA;
                textBoxC1.Text = DataJson.C1;
                textBoxC2.Text = DataJson.C2;
                if(DataJson.TB1 == "1")
                {
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = true;
                }   
                else if(DataJson.TB1 == "0")
                {
                    pictureBox1.Visible = true;
                    pictureBox3.Visible = false;
                }
                if (DataJson.TB2 == "1")
                {
                    pictureBox4.Visible = false;
                    pictureBox2.Visible = true;
                }
                else if (DataJson.TB2 == "0")
                {
                    pictureBox4.Visible = true;
                    pictureBox2.Visible = false;
                }

            }
            catch(Exception)
            {
                
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void Ledon_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            serialPort1.WriteLine("{\"TB1\":\"1\"}");
        }

        private void Ledoff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            serialPort1.WriteLine("{\"TB1\":\"0\"}");
        }

        private void Quaton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            serialPort1.WriteLine("{\"TB2\":\"1\"}");
        }

        private void Quatoff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            serialPort1.WriteLine("{\"TB2\":\"0\"}");
        }

        private void send1_Click(object sender, EventArgs e)
        {
            if(textBoxCC1.Text == "")
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            else
            {
                serialPort1.WriteLine("{\"C1\":\"" + textBoxCC1.Text +"\"}");
            }    
        }

        private void send2_Click(object sender, EventArgs e)
        {
            if (textBoxCC2.Text == "")
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            else
            {
                serialPort1.WriteLine("{\"C2\":\"" + textBoxCC2.Text + "\"}");
            }
            
        }
    }
}
