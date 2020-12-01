using System;
using System.Net;
using System.Net.Sockets;

namespace ReceiverImplementation
{
    public class UdpReciver
    {
        UdpClient receiver;

        public UdpReciver(int port)
        {
            receiver = new UdpClient(port);
        }
        public void Start()
        {
            IPEndPoint remoteIp = null;
            Console.WriteLine("recivestarted");
            while (true)
            {
                byte[] data = receiver.Receive(ref remoteIp); // получаем данные
                Console.WriteLine("get package");
            }
        }
    }
}
