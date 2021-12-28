using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MyVi.API.Entities
{
    public partial class PaymentCard
    {
        public PaymentCard()
        {
            UserRechargeHistory = new HashSet<UserRechargeHistory>();
        }

        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public int Cvv { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime OnUpdated { get; set; }
        public DateTime OnCreated { get; set; }

        public virtual ICollection<UserRechargeHistory> UserRechargeHistory { get; set; }
    }
}
