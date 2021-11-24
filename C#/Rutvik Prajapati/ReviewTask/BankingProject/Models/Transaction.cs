using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankingProject.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int AccountNumberId { get; set; }
        public int CustomerId { get; set; }
        public int TransactionAmount { get; set; }
        public int Status { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
