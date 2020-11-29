using System;
using System.Net.Sockets;
using System.Text;

namespace udpSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient();
            client.Connect("localhost", 8001);
            string message = "Hello world!";
            byte[] data = Encoding.UTF8.GetBytes(message);
            int numberOfSentBytes = client.Send(data, data.Length);
            client.Close();
            Console.WriteLine(numberOfSentBytes);
        }
    }
}
