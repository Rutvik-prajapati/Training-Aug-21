using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankingProject.Models
{
    public partial class Account
    {
        public int AccountNumber { get; set; }
        public int CurrentBalance { get; set; }
        public int CustomerId { get; set; }
        public int AccountTypeId { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
