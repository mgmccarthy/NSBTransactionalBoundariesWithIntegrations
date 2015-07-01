using NSBTransactionalBoundariesWithIntegrations.Data;
using NServiceBus;
using NServiceBus.Config;

namespace NSBTransactionalBoundariesWithIntegrations.OrderEndpoint
{
    public class EnsureTablesAreCreatedWhenConfiguringEndpoint : IWantToRunWhenConfigurationIsComplete
    {
        public void Run(Configure config)
        {
            using (var context = new Context())
                context.Database.Initialize(false);
        }
    }
}
