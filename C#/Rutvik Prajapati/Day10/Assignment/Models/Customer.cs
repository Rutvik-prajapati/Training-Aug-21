using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day10Task.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
