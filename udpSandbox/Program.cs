using StockQuoteGenerators;
using UdpReciverPrj;
using UdpSenderPrj;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace udpSandbox
{
    namespace UdpClientApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                NaiveGenerator naiveGenerator = new NaiveGenerator(10, 4000);
                IPAddress ip = IPAddress.Loopback;
                int port = 80;

                UdpSender sender = new UdpSender(ip, port, naiveGenerator);
                var udpReciver = new UdpReciver(port);
                //Thread threadSend1 = new Thread(new ThreadStart(sender.Start));
                //Thread threadSend2 = new Thread(new ThreadStart(sender.Start));
                //Thread threadRecive = new Thread(new ThreadStart(udpReciver.Start));
                //threadSend1.Start();
                //threadSend2.Start();
                //threadRecive.Start();
                var task1 = Task.Run(sender.Start);
                var task2 = Task.Run(udpReciver.Start);
                var foo =task1.Status;
                Thread.Sleep(10000);
                Console.WriteLine($"Get:{udpReciver.Count}");
            }

        }
    }
}
