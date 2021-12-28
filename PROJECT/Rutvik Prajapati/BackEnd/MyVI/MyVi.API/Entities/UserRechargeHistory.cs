using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MyVi.API.Entities
{
    public partial class UserRechargeHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public int PaymentCardId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime OnUpdated { get; set; }
        public DateTime OnCreated { get; set; }

        public virtual PaymentCard PaymentCard { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual User User { get; set; }
    }
}
