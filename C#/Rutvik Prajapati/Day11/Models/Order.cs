using System;
using System.Collections.Generic;
using System.Text;

namespace Day11Task.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int GrandTotal { get; set; }
        public int Status { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
