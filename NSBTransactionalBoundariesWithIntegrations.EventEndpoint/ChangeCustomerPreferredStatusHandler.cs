using System.Linq;
using NSBTransactionalBoundariesWithIntegrations.Data;
using NSBTransactionalBoundariesWithIntegrations.Messages.Events;
using NServiceBus;

namespace NSBTransactionalBoundariesWithIntegrations.EventEndpoint
{
    public class ChangeCustomerPreferredStatusHandler : IHandleMessages<OrderPlaced>
    {
        public void Handle(OrderPlaced message)
        {
            using (var context = new Context())
            {
                var customerPreferred = context.CustomerPreferred.SingleOrDefault(x => x.CustomerId == message.CustomerId);
                if (customerPreferred != null)
                    return;

                if (message.CustomerId == 1)
                    context.CustomerPreferred.Add(new CustomerPreferred { CustomerId = message.CustomerId, IsPreferred = true });
                context.SaveChanges();
            }
        }
    }
}
