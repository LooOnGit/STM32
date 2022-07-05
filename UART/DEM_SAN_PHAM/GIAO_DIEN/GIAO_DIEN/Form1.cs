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
using GIAO_DIEN.Properties;

namespace GIAO_DIEN
{
    public partial class Form1 : Form
    {
        string ReceiveData = String.Empty;
        string TransmitData = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                comboBox1.Items.Add(port);
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
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
                        textBox1.BackColor = Color.Lime;
                        textBox1.Text = "Connection...";
                        comboBox1.Enabled = false;//đong com
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("COM Port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    textBox1.BackColor = Color.Red;
                    textBox1.Text = "Disconnected!";
                    comboBox1.Enabled = true;//đong com
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
            try
            {
                string temp = "";
                while(serialPort1.BytesToRead > 0)
                {
                    char ch = Convert.ToChar(serialPort1.ReadChar());
                    temp += ch.ToString();

                    Thread.Sleep(10);
                }    
                string[] tach = temp.Split(',');
                if(tach.Length >= 2)
                {
                    soLuong.Value = Convert.ToDecimal(tach[0]);
                    soThung.Value = Convert.ToDecimal(tach[1]);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                throw;
            }
    
        }
    }
}
