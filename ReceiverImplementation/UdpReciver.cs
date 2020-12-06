using System;
using System.Net;
using System.Net.Sockets;

namespace UdpReciverPrj
{
    public class UdpReciver
    {
        UdpClient receiver;
        public ulong Count { get;private set; }
        public UdpReciver(int port)
        {
            receiver = new UdpClient(port);
            Count = 0;
        }
        public void Start()
        {
            IPEndPoint remoteIp = null;
            Console.WriteLine("recivestarted");
            while (true)
            {
                byte[] data = receiver.Receive(ref remoteIp); // получаем данные
                Count++;
            }
        }
    }
}
