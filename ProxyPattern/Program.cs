using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing proxy pattern");
            IServer serverProxy = new NewServerProxy();

            serverProxy.TakeOrder("order from new Server Proxy");
            serverProxy.DeliverOrder();
            serverProxy.ProcessPayment("payment");

            Console.ReadLine();
        }
    }
}
