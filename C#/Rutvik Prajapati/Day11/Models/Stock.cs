using System;
using System.Collections.Generic;
using System.Text;

namespace Day11Task.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public int? ToyId { get; set; }
        public int Quantity { get; set; }

        public Plant Plant { get; set; }
        public Toy Toy { get; set; }
    }
}
