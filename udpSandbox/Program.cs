using GeneratorImplementations;
using SenderImplementations;
using StockQuoteGeneratorPrj;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace udpSandbox
{
    class Program
    {
        static StockQuoteGenerator stockQuoteGenerator;
        static void Main(string[] args)
        {
            NaiveGenerator naiveGenerator = new NaiveGenerator(10, 4000);
            IPAddress ip = IPAddress.Loopback;
            int port = 8001;
            ISender countSender = new UdpSender(ip, port);
            stockQuoteGenerator = new StockQuoteGenerator(naiveGenerator, countSender);

            Thread thread = new Thread(new ThreadStart(start));
            thread.Start();
        }
        static void start()
        {
            stockQuoteGenerator.Start();
        }
    }
}
