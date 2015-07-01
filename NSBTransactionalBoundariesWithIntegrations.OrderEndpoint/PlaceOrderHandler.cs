using NSBTransactionalBoundariesWithIntegrations.Data;
using NSBTransactionalBoundariesWithIntegrations.Messages.Commands;
using NSBTransactionalBoundariesWithIntegrations.Messages.Events;
using NServiceBus;

namespace NSBTransactionalBoundariesWithIntegrations.OrderEndpoint
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        private readonly IBus bus;

        public PlaceOrderHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(PlaceOrder message)
        {
            using (var context = new Context())
            {
                context.Order.Add(new Data.Order { OrderId = message.OrderId, ProductId = message.ProductId, CustomerId = message.CustomerId, Quantity = message.Quantity });
                context.SaveChanges();
            }
            bus.Publish(new OrderPlaced { OrderId = message.OrderId, CustomerId = message.CustomerId });
        }
    }
}

