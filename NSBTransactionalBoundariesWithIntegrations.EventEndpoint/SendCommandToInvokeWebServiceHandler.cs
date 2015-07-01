using System;
using NSBTransactionalBoundariesWithIntegrations.Messages.Commands;
using NSBTransactionalBoundariesWithIntegrations.Messages.Events;
using NServiceBus;

namespace NSBTransactionalBoundariesWithIntegrations.EventEndpoint
{
    public class SendCommandToInvokeWebServiceHandler : IHandleMessages<OrderPlaced>
    {
        private readonly IBus bus;

        public SendCommandToInvokeWebServiceHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(OrderPlaced message)
        {
            throw new Exception("the web service call failed");
            //bus.SendLocal(new InvokeWebService { OrderId = message.OrderId, CustomerId = message.CustomerId });
        }
    }
}
