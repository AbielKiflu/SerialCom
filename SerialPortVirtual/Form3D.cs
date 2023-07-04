using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortVirtual
{
    public partial class Form3D : Form
    {
        public Form3D()
        {
            InitializeComponent();
        }

        private void Form3D_Load(object sender, EventArgs e)
        {
            this.Text = "File " + filePath + "Opened";
        }
    }
}
