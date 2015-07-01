using System;
using NSBTransactionalBoundariesWithIntegrations.Messages.Commands;
using NServiceBus;

namespace NSBTransactionalBoundariesWithIntegrations.EventEndpoint
{
    public class InvokeWebServiceHandler : IHandleMessages<InvokeWebService>
    {
        public void Handle(InvokeWebService message)
        {
            throw new Exception("the web service call failed");
        }
    }
}
