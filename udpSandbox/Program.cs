using GeneratorImplementations;
using SenderImplementations;
using StockQuoteGeneratorPrj;
using System;
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
            CountSender countSender = new CountSender();
            stockQuoteGenerator = new StockQuoteGenerator(naiveGenerator, countSender);

            Thread thread = new Thread(new ThreadStart(start));
            thread.Start();
            while (true)
            {
                Console.WriteLine(countSender.GetCount());
            }
        }
        static void start()
        {
            stockQuoteGenerator.Start();
        }
    }
}
