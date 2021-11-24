using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day10Task.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Status { get; set; }

        public Order Order { get; set; }
    }
}
