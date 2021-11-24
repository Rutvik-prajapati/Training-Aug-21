using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankingProject.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Account = new HashSet<Account>();
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string BranchName { get; set; }

        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
