using System;

namespace NSBTransactionalBoundariesWithIntegrations.Messages.Commands
{
    public class PlaceOrder
    {
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
    }
}
