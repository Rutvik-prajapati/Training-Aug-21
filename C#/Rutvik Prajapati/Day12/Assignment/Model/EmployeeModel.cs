using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day12Task.API.Model
{
    public class EmployeeModel
    {
        public Int64 EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
