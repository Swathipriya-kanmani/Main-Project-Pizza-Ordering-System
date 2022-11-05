using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace PizzaProject.Models
{
    public partial class User
    {
        public User()
        {
            OrderTabs = new HashSet<OrderTab>();
        }

        [DisplayName("User ID")]
        [Required] 
        public int UserId { get; set; }


        [DisplayName("Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name should be in alphabet")]
        public string? Name { get; set; }

        [DisplayName("User Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Username should be in alphabet")]
        public string Username { get; set; } = null!;

        [DisplayName("Mobile")]
        [Required]
        
        public string? Mobile { get; set; }

        [DisplayName("Email")]
        [Required]
        
        public string Email { get; set; } = null!;

        [DisplayName("Password")]
        [Required]
        
        public string Password { get; set; } = null!;

        [DisplayName("Address")]
        [Required]
        public string? Address { get; set; }

        public virtual ICollection<OrderTab> OrderTabs { get; set; }
    }
}
