using StockQuoteGenerators;
using StockQuoteModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UdpSenderPrj
{
    public class UdpSender
    {
        UdpClient client;
        IPEndPoint endPoint;
        IGenerator generator;
        public UdpSender(IPAddress IPAddress, int port, IGenerator generator)
        {
            client = new UdpClient();
            endPoint  = new IPEndPoint(IPAddress, port);
            this.generator = generator;
        }
        public void Start()
        {
            while (true)
            {
                var stockQuote = generator.GetNextStockQuote();
                SendStockQuote(stockQuote);
            }
        }
        private void SendStockQuote(StockQuote stockQuote)
        {
            var data = BitConverter.GetBytes(stockQuote.Value);
            var sented = client.Send(data, data.Length, endPoint);
        }
    }
}
