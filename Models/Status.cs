using System;
using System.Collections.Generic;

namespace PizzaProject.Models
{
    public partial class Status
    {
        public int OrderId { get; set; }
        public int? PizzaId { get; set; }
        public int? Quantity { get; set; }
        public int? UserId { get; set; }
        public string? OrderDetails { get; set; }
        public int? PaymentId { get; set; }
        public string? Status1 { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
