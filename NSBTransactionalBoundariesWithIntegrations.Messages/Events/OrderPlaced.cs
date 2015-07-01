using System;

namespace NSBTransactionalBoundariesWithIntegrations.Messages.Events
{
    public class OrderPlaced
    {
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
    }
}
