using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day11Task.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ToyId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public bool IsCount { get; set; }
        public Customer Customer { get; set; }
        public Toy Toy { get; set; }
    }
}
