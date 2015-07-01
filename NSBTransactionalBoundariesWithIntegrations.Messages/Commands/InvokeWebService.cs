using System;

namespace NSBTransactionalBoundariesWithIntegrations.Messages.Commands
{
    public class InvokeWebService
    {
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
    }
}
