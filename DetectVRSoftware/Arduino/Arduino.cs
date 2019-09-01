using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace DetectVR
{
    class Arduino
    {
        public Arduino()
        {
            Port = new SerialPort();
            Data = new byte[1];
            Port.BaudRate = 9600;
            Console.WriteLine("Write down the COM port that your arduino is connected to (space sensitive): ");
            Port.PortName = Console.ReadLine();
            Port.Open();
        }

        public SerialPort Port { get; set; }
        public byte[] Data { get; set; }
    }
}
