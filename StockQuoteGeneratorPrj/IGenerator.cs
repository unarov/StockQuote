using StockQuoteModel;

namespace StockQuoteGeneratorPrj
{
    public interface IGenerator
    {
        public StockQuote GetNextStockQuote();
    }
}
