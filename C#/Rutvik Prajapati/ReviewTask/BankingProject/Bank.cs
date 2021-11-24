using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.Services.CustomerServices;
using BankingProject.Modal;

namespace BankingProject
{
    public class Bank
    {
        private ICustomerServices _customerServices;
        public Bank(ICustomerServices customerServices)
        {
            this._customerServices = customerServices;
        }
        public static void addAccountOfCustomer()
        {
            ICustomerServices customerServices = new CustomerServices();
            Bank bank = new Bank(customerServices);

            var newCustomerAccount = new BankAccount();
            Console.WriteLine("Enter Customer Name:");
            newCustomerAccount.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Account type Saving Or Current :");
            newCustomerAccount.AccountType = Console.ReadLine();
            Console.WriteLine("Enter Amount :");
            newCustomerAccount.Amount = Convert.ToInt32(Console.ReadLine());

            var result  = customerServices.openNewCustomerAccount(newCustomerAccount);
            Console.WriteLine(result);
        }

        public static void customerTransactionMoney()
        {
            ICustomerServices customerServices = new CustomerServices();
            Bank bank = new Bank(customerServices);
            var customerDetail = new CustomerModal();

            GetCustomerList();
            Console.WriteLine("Please select Customer Id :");
            customerDetail.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1.Withdraw 2.Deposite");
            customerDetail.TransactionStatus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount:");
            customerDetail.Amount = Convert.ToInt32(Console.ReadLine());
            var result = customerServices.customerTransaction(customerDetail);
            Console.WriteLine(result);

        }

        public static void changeCustomerName()
        {
            ICustomerServices customerServices = new CustomerServices();
            var customerDetail = new CustomerModal();
            GetCustomerList();
            Console.WriteLine("Select Customer Id :");
            customerDetail.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Customer Name :");
            customerDetail.CustomerName = Console.ReadLine();
            var result = customerServices.updateCustomerName(customerDetail);
            Console.WriteLine(result);
        }

        public static void ViewCustomerTransaction()
        {
            ICustomerServices customerServices = new CustomerServices();
            Bank bank = new Bank(customerServices);

            var transactionList = new List<TransactionDetailModal>();
            GetCustomerList();
            Console.WriteLine("Select CustomerId:");
            var customerId = Convert.ToInt32(Console.ReadLine());
            transactionList = customerServices.getCustomerTransactionDetail(customerId);
            Console.WriteLine("Account Number       Customer Name   Transactin Status    Amount     TotalBalance");
            foreach (var transaction in transactionList)
            {
                Console.WriteLine($"   {transaction.AccountNumber}\t\t{transaction.CustomerName}\t\t{transaction.TransactionStatus}\t\t{transaction.Amount}\t\t{transaction.TotalAmount}");
            }
            
        }

        public static void GetCustomerList()
        {
            ICustomerServices customerServices = new CustomerServices();
            Bank bank = new Bank(customerServices);
            var customerList = new List<CustomerModal>();
            Console.WriteLine("Customer List are given Below:");
            customerList = customerServices.getCustomerList();
            foreach (var customer in customerList)
            {
                Console.WriteLine($"Customer Id : {customer.Id} Customer Name : {customer.CustomerName}");
            }
        }
    }
}
