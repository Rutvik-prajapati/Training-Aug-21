using System;
using System.Collections.Generic;
using System.Text;

namespace Day11Task.API.Model
{
    public class OrderListModel
    {
        public int CustomerId { get; set; }
        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
