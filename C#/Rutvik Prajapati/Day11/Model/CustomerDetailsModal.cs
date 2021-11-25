using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day11Task.API.Model
{
    public class CustomerDetailsModal
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
    }
}
