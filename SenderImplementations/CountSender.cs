using StockQuoteGeneratorPrj;
using StockQuoteModel;
using System;

namespace SenderImplementations
{
    public class CountSender : ISender
    {
        ulong sendCount;

        public CountSender()
        {
            sendCount = 0;
        }

        public void SendStockQuote(StockQuote stockQuote)
        {
            sendCount++;
        }
        public ulong GetCount()
        {
            return sendCount;
        }
    }
}
