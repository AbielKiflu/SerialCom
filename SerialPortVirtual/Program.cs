using System.IO.Ports;

namespace SerialPortVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {

             

            // display list of ports
            Console.WriteLine(string.Join(", ",SerialPort.GetPortNames()));

            SerialPort conn = Connection.getPort("COM1");
            conn.Open();

            conn.WriteLine("Hi there");
    

            conn.Close();
            Console.ReadKey();

        }
    }
}