using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortVirtual
{
    internal class Connection
    {

        private static SerialPort port;

        private Connection() { }


        public static SerialPort getPort( string name)
        {
            if(port == null)
                return port = new SerialPort(name);
            return port;
        }



    }
}
