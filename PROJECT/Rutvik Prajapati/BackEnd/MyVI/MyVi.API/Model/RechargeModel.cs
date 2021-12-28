using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVi.API.Model
{
    public class RechargeModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public int Cvv { get; set; }
    }
}
