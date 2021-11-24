using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day10Task.Models
{
    public class Toy
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public int PlantId { get; set; }
        public Plant Plant { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
