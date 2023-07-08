using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCsharp
{
    public partial class FrmArduino : Form
    {
        private static SerialPort? serialPort;
        public FrmArduino()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM6");
            serialPort.BaudRate = 9600;
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                try
                {
                    serialPort.Open();
                    serialPort.Write("ON");
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                try
                {
                    serialPort.Open();
                    serialPort.Write("OFF");
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK);
                }

            }
        }
    }
}