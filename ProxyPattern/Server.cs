using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Server : IServer
    {
        private string _order;
        public string DeliverOrder()
        {
            return _order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine($"Payment for order ({payment}) processed");
        }

        public void TakeOrder(string order)
        {
            Console.WriteLine($"Taking order for {order}");
            _order = order;
        }
    }
}
