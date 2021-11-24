using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.Modal;

namespace BankingProject.Services.CustomerServices
{
    public interface ICustomerServices
    {
        string openNewCustomerAccount(BankAccount bankAccount);
        string updateCustomerName(CustomerModal customer);
        List<CustomerModal> getCustomerList();
        string customerTransaction(CustomerModal customer);
        List<TransactionDetailModal> getCustomerTransactionDetail(int  customerId);
    }
}
