using System;
using System.Collections.Generic;

namespace PizzaProject.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public string? TransId { get; set; }
        public int? OrderId { get; set; }
        public string? Status { get; set; }
    }
}
