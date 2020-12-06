using StockQuoteModel;
using System;

namespace StockQuoteGenerators
{
    public class NaiveGenerator : IGenerator
    {
        private double minValue;
        private double maxValue;
        Random random;

        public NaiveGenerator(double minValue, double maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            random = new Random();
        }

        public StockQuote GetNextStockQuote()
        {
            return new StockQuote { Value = random.NextDouble() * (maxValue - minValue) };
        }
    }
}
