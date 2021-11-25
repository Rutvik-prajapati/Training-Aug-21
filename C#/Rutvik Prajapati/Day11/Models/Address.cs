using System;
using System.Collections.Generic;
using System.Text;

namespace Day11Task.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
