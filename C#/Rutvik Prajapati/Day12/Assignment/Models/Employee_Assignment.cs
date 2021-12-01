using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day12Task.API.Models
{
    public class Employee_Assignment
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 EmployeeId { get; set; }
        public Int64 AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public Employee Employee { get; set; }
    }
}
