using System;

namespace BankingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("United Bank");
            while (true)
            {
                Console.WriteLine("\n\nEnter Given List Of Operation Please Select Any One Of Them.");
                Console.WriteLine("1.Customer Services" +
                                  "\n2.Bank Officer Services" +
                                  "\n3.Exit");
                var num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("\nCustomer Operations Please Select Any One Of Them.");
                        Console.WriteLine("1.Customer Withdraw/Deposite" +
                                          "\n2.Update Customer Name" +
                                          "\n3.View Customer Transaction Detail" +
                                          "\n4.Get Customer List" +
                                          "\n5.Exit");
                        var num2 = Convert.ToInt32(Console.ReadLine());
                        switch (num2)
                        {
                            case 1:
                                Bank.customerTransactionMoney();
                                break;
                            case 2:
                                Bank.changeCustomerName();
                                break;
                            case 3:
                                Bank.ViewCustomerTransaction();
                                break;
                            case 4:
                                Bank.GetCustomerList();
                                break;
                            case 5:
                                return;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Bank Operation Please Select Any One Of Them.");
                        Console.WriteLine("1.Add new Customer Account" +
                                          "\n2.Get Customer List " +
                                          "\n3.Exit");
                        var num3 = Convert.ToInt32(Console.ReadLine());
                        switch (num3)
                        {
                            case 1:
                                Bank.addAccountOfCustomer();
                                break;
                            case 2:
                                Bank.GetCustomerList();
                                break;
                            case 3:
                                return;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
