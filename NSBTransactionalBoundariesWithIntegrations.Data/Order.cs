using System;
using System.ComponentModel.DataAnnotations;

namespace NSBTransactionalBoundariesWithIntegrations.Data
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
    }
}
