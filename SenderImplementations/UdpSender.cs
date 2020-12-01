﻿using StockQuoteGeneratorPrj;
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
        IPEndPoint endPoint;
        public UdpSender(IPAddress IPAddress, int port)
        {
            client = new UdpClient();
            endPoint  = new IPEndPoint(IPAddress, port);
        }
        public void SendStockQuote(StockQuote stockQuote)
        {
            var data = BitConverter.GetBytes(stockQuote.Value);
            var sented = client.Send(data, data.Length, endPoint);
            Console.WriteLine($"Data has beed sented {sented}");
        }
    }
}
