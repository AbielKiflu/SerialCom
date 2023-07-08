using System.IO.Ports;




namespace SerialPortVirtual
{
    public partial class WinForm : Form
    {

        private SerialPort? port = null;



        public WinForm()
        {
            InitializeComponent();

            //Add event handler to each textbox in the pnlPort ...
            foreach (var control in PnlPort.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)control;
                    textBox.TextChanged += MyValidateEventHandler;
                }
            }

        }

        private void MyValidateEventHandler(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Simple validation TODO validate values types
            if (string.IsNullOrEmpty(textBox.Text))
            {
                btnSavePortConf.Enabled = false;
            }
        }


        // Load available ports on formLoad event
        private async void WinForm_Load(object sender, EventArgs e)
        {
            string[] ports = await LoadPorts();
            cmbPorts.DataSource = ports;

        }


        //Serial port message received 
        private void OnMessageReceived(object sender, SerialDataReceivedEventArgs e)
        {
            MessageBox.Show("Fired");
        }




        //Check if Port config textbox not empty
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
                    port.DataReceived += new SerialDataReceivedEventHandler(OnMessageReceived);
                }
            }
        }


        //Modify Port Config
        private void btnSavePortConf_Click(object sender, EventArgs e)
        {
            using (port = Connection.getPort(cmbPorts.Text))
            {

                try
                {
                    port.Open();
                    port.BaudRate = int.Parse(txtBaudRate.Text);
                    //port.Parity = txtParity.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing the configration" + ex.Message.ToString());
                }

            }

        }


        //Send Text Message
        private void btnSendText_Click(object sender, EventArgs e)
        {
            //txtPortName.Text.Trim()
            using (port = Connection.getPort(cmbPorts.Text))
            {
                try
                {
                    port.Open();
                    string receivedData = port.ReadExisting();
                    txtReceive.Text = receivedData;
                    port.WriteLine(txtMessage.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.HelpLink + ex.Message.ToString());
                }
            }
        }






        // helper methods get list of ports
        private async Task<string[]> LoadPorts()
        {
            string[] ports = await Task.Run(() => SerialPort.GetPortNames());
            return ports;
        }

        private async void btnLoadStl_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // openFileDialog Todo receive.....
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Filter = "STL files(*.stl)|*.stl";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    filePath = ofd.FileName;
                }

            }


            // transfer byte of stl file
            using (port = Connection.getPort(cmbPorts.Text))
            {
                try
                {
                    port.Open();
 
                        {
                            byte[] buffer = new byte[64];

                            int bytesRead;
                            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                port.Write(buffer, 0, bytesRead);
                            }
                        }
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.HelpLink + ex.Message.ToString());
                }
            }}
        }

 
    }
}
