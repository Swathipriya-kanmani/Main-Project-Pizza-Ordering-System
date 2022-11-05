using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace PizzaProject.Models
{
    public partial class PaymentTab
    {

        [DisplayName("Name On Card")]
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name should be in alphabet")]
        public string? NameOnCard { get; set; }

        [DisplayName("Credit Card Number")]
        [Required]
        public decimal? CreditCardNumber { get; set; }

        [DisplayName("Expiry Date")]
        [Required]
        public DateTime? ExpDate { get; set; }

        [DisplayName("CVV Number")]
        [Required]
        public int? Cvv { get; set; }
    }
}


