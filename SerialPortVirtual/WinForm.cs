using System.IO.Ports;




namespace SerialPortVirtual
{
    public partial class WinForm : Form
    {

        private SerialPort? port = null;

        public WinForm()
        {
            InitializeComponent();
        }

        private async void WinForm_Load(object sender, EventArgs e)
        {
            string[] ports = await LoadPorts();
            cmbPorts.DataSource = ports;
        }


        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbPorts.Text))
            {
                // get the props of the port
                using (port = Connection.getPort(cmbPorts.Text))
                {
                    txtBaudRate.Text = port.BaudRate.ToString();
                    txtDataBits.Text = port.DataBits.ToString();
                    txtParity.Text = port.Parity.ToString();
                    txtStopBits.Text = port.StopBits.ToString();
                }
            }
        }

        private void btnSavePortConf_Click(object sender, EventArgs e)
        {
            using (port = Connection.getPort(cmbPorts.Text))
            {

                try
                {
                    if (!port.IsOpen)
                    {
                        port.Open();
                        port.BaudRate = int.Parse(txtBaudRate.Text);
                        //port.Parity = txtParity.Text;
                        
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Error changing the configration" + ex.Message.ToString());
                }

                

            }

       

        }








        // helper methods get list of ports
        private async Task<string[]> LoadPorts()
        {
            string[] ports = await Task.Run(() => SerialPort.GetPortNames());
            return ports;
        }


    }
}
