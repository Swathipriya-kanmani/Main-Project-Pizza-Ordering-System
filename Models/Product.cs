using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaProject.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderTabs = new HashSet<OrderTab>();
        }

        [DisplayName("Pizza ID")]
        public int PizzaId { get; set; }

        [DisplayName("Pizza Name")]
        public string PizzaName { get; set; } = null!;

        [DisplayName("Pizza Crust")]
        public string? PizzaCrust { get; set; }

        [DisplayName("Prize")]
        public decimal? Prize { get; set; }

        //[DisplayName("Number Of Pizzas")]
        public int? NoOfPizzas { get; set; }

        [DisplayName("Number Of Slices")]
        public int? NoOfSlices { get; set; }

        [DisplayName("Toppings")]
        public string? Toppings { get; set; }

        public virtual ICollection<OrderTab> OrderTabs { get; set; }
    }
}




