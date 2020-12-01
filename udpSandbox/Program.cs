using GeneratorImplementations;
using ReceiverImplementation;
using SenderImplementations;
using StockQuoteGeneratorPrj;
using System.Net;
using System.Threading;

namespace udpSandbox
{
    namespace UdpClientApp
    {
        class Program
        {
            static StockQuoteGenerator stockQuoteGenerator;
            static UdpReciver udpReciver;
            static void Main(string[] args)
            {
                NaiveGenerator naiveGenerator = new NaiveGenerator(10, 4000);
                IPAddress ip = IPAddress.Loopback;
                int port = 80;

                ISender countSender = new UdpSender(ip, port);
                stockQuoteGenerator = new StockQuoteGenerator(naiveGenerator, countSender);

                udpReciver = new UdpReciver(port);
                StartTest();
                Thread.Sleep(10000);
            }

            private static void StartTest()
            {
                Thread sendThread = new Thread(new ThreadStart(StartSender));
                Thread reciveThread = new Thread(new ThreadStart(StartReciver));
                sendThread.Start();
                reciveThread.Start();
            }

            static void StartSender()
            {
                stockQuoteGenerator.Start();
            }
            static void StartReciver()
            {
                udpReciver.Start();
            }
        }
    }
}
