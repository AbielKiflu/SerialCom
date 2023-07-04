using System.IO.Ports;
using System.Windows;

namespace SerialPortVirtual
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FormView formView = new FormView();
            Application app = new Application();
            app.Run(formView);

        }
    }
}