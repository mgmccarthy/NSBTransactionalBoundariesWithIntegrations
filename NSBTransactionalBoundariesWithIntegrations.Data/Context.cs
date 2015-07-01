using System.Data.Entity;

namespace NSBTransactionalBoundariesWithIntegrations.Data
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<CustomerPreferred> CustomerPreferred { get; set; }
    }

    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
    }
}
