using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;

namespace SerialPortVirtual
{
    public partial class Form3D : Form
    {
        private SceneControl openGLControl;
        public Form3D()
        {
            InitializeComponent();
            openGLControl = new SceneControl();
            openGLControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(openGLControl);
        }

        private void Form3D_Load(object sender, EventArgs e)
        {
            this.Text = "File " + filePath + " Opened";
        }
    }
}
