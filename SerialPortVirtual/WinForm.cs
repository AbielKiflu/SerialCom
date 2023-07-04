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

namespace SerialPortVirtual
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private async void WinForm_Load(object sender, EventArgs e)
        {
            try
            {
                string[] ports = await LoadPorts();
                cmbPorts.DataSource = ports;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while loading ports");
            }


        }




        // get list of ports
        private async Task<string[]> LoadPorts()
        {
            string[] ports = await Task.Run(() => SerialPort.GetPortNames());
            return ports;
        }



    }
}
