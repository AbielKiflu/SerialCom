using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ArduinoCsharp
{

    public partial class FrmArduino : Form
    {
        private static SerialPort? serialPort;
        private delegate void displayIt(string data);


        // serialport eventhdlr




        public FrmArduino()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM6");
            serialPort.BaudRate = 9600;
            serialPort.DataReceived += OnReceived;
            serialPort.Open();
        }

        // on receive data from port
        private void OnReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string data = serialPort.ReadLine();
            Console.WriteLine(data);

            if (txtData.InvokeRequired)
            {
                txtData.Invoke(new displayIt((data)=>txtData.Text=data), new object[] { data });
            }
 


        }

        private void btnON_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                try
                {

                    serialPort.Write("ON");

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
                    serialPort.Write("OFF");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK);
                }

            }
        }

        private void FrmArduino_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }
    }
}