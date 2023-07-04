using System.IO.Ports;
 



namespace SerialPortVirtual
{
    public partial class WinForm : Form
    {

        SerialPort port = null;
        public WinForm()
        {
            InitializeComponent();
        }

        private async void WinForm_Load(object sender, EventArgs e)
        {
            string[] ports = await LoadPorts();
            cmbPorts.DataSource = ports;


        }




        // get list of ports
        private async Task<string[]> LoadPorts()
        {
            string[] ports = await Task.Run(() => SerialPort.GetPortNames());
            return ports;
        }

        private void btnLoadStl_Click(object sender, EventArgs e)
        {

        }

        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (!string.IsNullOrEmpty(cmbPorts.Text))
            {
                // get the props of the port
                using(port = Connection.getPort(cmbPorts.Text))
                {
                    txtBaudRate.Text = port.BaudRate.ToString();
                    txtDataBits.Text = port.DataBits.ToString();
                    txtParity.Text = port.Parity.ToString();
                    txtStopBits.Text = port.StopBits.ToString();
                  
                }

             
            }
        }
    }
}
