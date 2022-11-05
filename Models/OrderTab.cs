using System;
using System.Collections.Generic;

namespace PizzaProject.Models
{
    public partial class OrderTab
    {
        public int OrderId { get; set; }
        public int? PizzaId { get; set; }
        public int? UserId { get; set; }
        public decimal? Prize { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? OrderDateTime { get; set; }

        public virtual Product? Pizza { get; set; }
        public virtual User? User { get; set; }
    }
}
