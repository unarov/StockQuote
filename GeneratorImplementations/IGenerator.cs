using StockQuoteModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockQuoteGenerators
{
    public interface IGenerator
    {
        public StockQuote GetNextStockQuote();
    }
}
