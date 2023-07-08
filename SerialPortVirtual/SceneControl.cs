using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace SerialPortVirtual
{
    internal class SceneControl : GLControl 
    {

        public SceneControl()
        {
            this.Load += SceneControl_Load;
        }


        private void SceneControl_Load(object sender, EventArgs e)
        {
            MakeCurrent();
            GL.ClearColor(Color.Black);
            GL.Enable(EnableCap.DepthTest);
            GL.Viewport(0, 0, Width, Height);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            
            MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // operation of rendering

            this.SwapBuffers();
            base.OnPaint(e);
        }


    }
}
