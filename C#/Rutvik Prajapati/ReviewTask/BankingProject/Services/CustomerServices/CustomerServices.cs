using BankingProject.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.Models;
using BankingProject.EnumHelper;
using System.Linq;


namespace BankingProject.Services.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        public string customerTransaction(CustomerModal customer)
        {
            using (var dbContex = new UnitedBankDBContext())
            {
                var accountDetail = dbContex.Account.Where(x => x.CustomerId == customer.Id).FirstOrDefault();
                int status = 0;
                if (accountDetail != null && accountDetail.CurrentBalance>0)
                {
                    if (customer.TransactionStatus == 1)
                    {
                        status = (int)EnumHelper.TransactionStatusEnum.Withdraw;
                        accountDetail.CurrentBalance = accountDetail.CurrentBalance - customer.Amount;
                        if (accountDetail.CurrentBalance < 1000)
                        {
                            return "You can't withdraw money because not have enogh amount";
                        }
                    }
                    if (customer.TransactionStatus == 2)
                    {
                        status = (int)EnumHelper.TransactionStatusEnum.Deposit;
                        accountDetail.CurrentBalance = accountDetail.CurrentBalance + customer.Amount;
                    }
                    dbContex.SaveChanges();
                }

                var newTransaction = new Transaction()
                {
                    AccountNumberId = accountDetail.AccountNumber,
                    CustomerId = accountDetail.CustomerId,
                    TransactionAmount = customer.Amount,
                    Status = status
                };
                dbContex.Transaction.Add(newTransaction);
                dbContex.SaveChanges();
                return $"transaction successfull.";
            }
        }

        public List<CustomerModal> getCustomerList()
        {
            var customerList = new List<CustomerModal>();
            using (var dbContext = new UnitedBankDBContext())
            {
                customerList = dbContext.Customer.Select(x=>new  CustomerModal()
                                                        {
                                                             Id = x.Id,
                                                             CustomerName = x.Name
                                                        }).ToList();
                return customerList;
            }
        }

        public List<TransactionDetailModal> getCustomerTransactionDetail(int customerId)
        {
            var transactionDetail = new List<TransactionDetailModal>();
            using (var dbContext = new UnitedBankDBContext())
            {
                transactionDetail = dbContext.Transaction.Where(x => x.CustomerId == customerId).Select(x => new TransactionDetailModal()
                {
                    AccountNumber = x.AccountNumberId,
                    CustomerName = x.Customer.Name,
                    Amount = x.TransactionAmount,
                    TransactionStatus = x.Status == 1 ? "Withdraw" : "Deposite"
                }).ToList();
                return transactionDetail;
            }
        }

        public string openNewCustomerAccount(BankAccount bankAccount)
        {
            using (var dbContext = new UnitedBankDBContext())
            {
                var accountType = new AccountType()
                {
                    Name = (int)EnumHelper.AccountTypeEnum.Current
                };
                var newCustomer = new Customer()
                {
                    Name = bankAccount.CustomerName,
                    BranchName = "Detroit Bank US"
                };
                dbContext.Customer.Add(newCustomer);
                dbContext.AccountType.Add(accountType);
                dbContext.SaveChanges();

                var customerDetail = dbContext.Customer.Where(x => x.Name == bankAccount.CustomerName).FirstOrDefault();
                var accountTypeDetail = dbContext.AccountType.Where(x => x.Name == (int)EnumHelper.AccountTypeEnum.Current).FirstOrDefault();

                if (customerDetail != null && accountTypeDetail!= null)
                {
                    var customerAccount = new Account()
                    {
                        CurrentBalance = bankAccount.Amount,
                        CustomerId = customerDetail.Id,
                        AccountTypeId = accountTypeDetail.Id
                    };
                    dbContext.Account.Add(customerAccount);
                    dbContext.SaveChanges();
                }
                return "Successfully created new customer account.";
            }
        }

        public string updateCustomerName(CustomerModal customer)
        {
            using (var dbContext = new UnitedBankDBContext())
            {
                var customerDetail = dbContext.Customer.Where(x => x.Id == customer.Id).FirstOrDefault();
                customerDetail.Name = customer.CustomerName;
                dbContext.SaveChanges();
                                
                return "Successfully updated customerName";
            }
        }


    }
}
