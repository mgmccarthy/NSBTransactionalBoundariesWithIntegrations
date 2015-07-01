using System;
using NSBTransactionalBoundariesWithIntegrations.Messages.Commands;

namespace NSBTransactionalBoundariesWithIntegrations.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBus.Init();

            Console.WriteLine("Press 'Enter' to place an Order. To exit, Ctrl + C");

            while (Console.ReadLine() != null)
            {
                ServiceBus.Bus.Send(new PlaceOrder { OrderId = Guid.NewGuid(), CustomerId = 1, ProductId = 1, Quantity = 101 });
            }
        }
    }
}
