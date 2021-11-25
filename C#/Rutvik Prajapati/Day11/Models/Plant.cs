using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day11Task.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }


        public ICollection<Toy> Toys { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
