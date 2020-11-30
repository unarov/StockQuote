using System;
using System.Threading;

namespace StockQuoteGeneratorPrj
{
    public class StockQuoteGenerator
    {
        IGenerator generator;
        ISender sender;

        public StockQuoteGenerator(IGenerator generator, ISender sender)
        {
            this.generator = generator;
            this.sender = sender;
        }
        public void Start()
        {
            while (true)
            {
                var stockQuote = generator.GetNextStockQuote();
                sender.SendStockQuote(stockQuote);
            }
        }
    }
}
