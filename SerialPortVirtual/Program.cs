using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows;

namespace SerialPortVirtual
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new WinForm());
            

        }
    }
}
