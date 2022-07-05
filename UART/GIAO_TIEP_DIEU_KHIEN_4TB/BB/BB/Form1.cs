using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using BB.Properties;

namespace BB
{
    public partial class Form1 : Form
    {
        #region Ham
        void InitCom()
        {
            cbxTenCom.DataSource = SerialPort.GetPortNames();

            for (int i = 0; i < cbxTenCom.Items.Count; i++)
            {
                if(Settings.Default.PortName == cbxTenCom.Items[i].ToString())
                {
                    cbxTenCom.SelectedIndex = i; // gan ten cong com luu truoc do
                    break;
                }    
            }
        }
        #endregion
        #region Form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitCom();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
            }    
        }
        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(UART.IsOpen == true)
                {
                    UART.DiscardInBuffer();
                    UART.DiscardOutBuffer();
                    UART.Close();
                }
                Settings.Default.PortName = cbxTenCom.Text;//gan ten cong com vao du lieu luu
                Settings.Default.Save(); //luu du lieu lai

                UART.PortName = cbxTenCom.Text;//thiet lap cong com muon ket noi
                UART.Open();//mo cong com

                if(UART.IsOpen)
                {
                    btnConnect.Enabled = false;
                    btnDisConnect.Enabled = true;
                }    
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                throw;
            }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (UART.IsOpen == true)
                {
                    UART.DiscardInBuffer();
                    UART.DiscardOutBuffer();
                    UART.Close();
                }
                btnConnect.Enabled = true;
                btnDisConnect.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                throw;
            }

        }

        private void btnBat1_Click(object sender, EventArgs e)
        {
            if(UART.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            UART.Write("1");
        }

        private void btnBat2_Click(object sender, EventArgs e)
        {
            if (UART.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            UART.Write("3");
        }

        private void btnBat3_Click(object sender, EventArgs e)
        {
            if (UART.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            UART.Write("5");
        }

        private void btnTat1_Click(object sender, EventArgs e)
        {
            if (UART.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            UART.Write("2");
        }

        private void btnTat2_Click(object sender, EventArgs e)
        {
            if (UART.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            UART.Write("4");
        }

        private void btnTat3_Click(object sender, EventArgs e)
        {
            if (UART.IsOpen == false)
            {
                MessageBox.Show("CHƯA MỞ CỔNG COM");
                return;
            }
            UART.Write("6");
        }
    }
}
