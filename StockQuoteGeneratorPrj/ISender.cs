using StockQuoteModel;

namespace StockQuoteGeneratorPrj
{
    public interface ISender
    {
        void SendStockQuote(StockQuote stockQuote);
    }
}
