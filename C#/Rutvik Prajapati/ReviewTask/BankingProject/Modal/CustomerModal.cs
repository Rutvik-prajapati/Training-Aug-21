using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.Modal
{
    public class CustomerModal
    {
        public int  Id { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
        public int TransactionStatus { get; set; }
    }
}
