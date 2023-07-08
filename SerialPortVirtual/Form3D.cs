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
using OpenTK.Graphics.OpenGL;

namespace SerialPortVirtual
{
    public partial class Form3D : Form
    {
        private SceneControl openGLControl;
        private STLModel stlModel;
        public string filePath { get; set; }

        public Form3D()
        {
            InitializeComponent();
            openGLControl = new SceneControl();
            openGLControl.Dock = DockStyle.Fill;
            openGLControl.Paint += openGLControl_Paint;
            pnlContainer.Controls.Add(openGLControl);
        }




        private void openGLControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();

            stlModel.Load(filePath);
            stlModel = new STLModel();
            stlModel.Render();

            openGLControl.SwapBuffers();
        }








    }
}
