using System;
using System.Threading;

namespace StockQuoteGeneratorPrj
{
    public class StockQuoteGenerator
    {
        IGenerator generator;

        public StockQuoteGenerator(IGenerator generator)
        {
            this.generator = generator;
        }
        public ulong GetStockQuote()
        {
            var stockQuote = generator.GetNextStockQuote();
            return stockQuote;
        }
    }
}
