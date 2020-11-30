using System;
using System.Threading;

namespace StockQuoteGeneratorPrj
{
    public class StockQuoteGenerator
    {
        IGenerator generator;
        ISender sender;
        Thread workThread; 

        public StockQuoteGenerator(IGenerator generator, ISender sender)
        {
            this.generator = generator;
            this.sender = sender;
            workThread = new Thread(new ThreadStart(work));
        }
        public void Start()
        {
            workThread.Start();
        }
        public void Stop()
        {
            workThread.Abort();
        }
        private void work()
        {
            var stockQuote = generator.GetNextStockQuote();
            sender.SendStockQuote(stockQuote);
        }
    }
}
