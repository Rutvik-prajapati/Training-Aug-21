using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.Modal
{
    public class TransactionDetailModal
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
        public string TransactionStatus { get; set; }
        public int TotalAmount { get; set; }
    }
}
