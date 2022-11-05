﻿using System;
using System.Collections.Generic;

namespace PizzaProject.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; } = null!;
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
