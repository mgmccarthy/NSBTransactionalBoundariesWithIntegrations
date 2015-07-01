using System.ComponentModel.DataAnnotations;

namespace NSBTransactionalBoundariesWithIntegrations.Data
{
    public class CustomerPreferred
    {
        [Key]
        public int CustomerId { get; set; }
        public bool IsPreferred{ get; set; }
    }
}
