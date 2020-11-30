using StockQuoteGeneratorPrj;
using StockQuoteModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SenderImplementations
{
    public class UdpSender : ISender
    {
        UdpClient client;
        public UdpSender(IPAddress IPAddress, int port)
        {
            client = new UdpClient();
            client.Connect(IPAddress, port);
        }
        public void SendStockQuote(StockQuote stockQuote)
        {
            var data = BitConverter.GetBytes(stockQuote.Value);
            client.Send(data, data.Length);
        }
    }
}
