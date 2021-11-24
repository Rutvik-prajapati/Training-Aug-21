using System;

namespace Day10Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toy Manufacturing Company");
            while (true)
            {
                Console.WriteLine("\nSelect Any one option");
                Console.WriteLine("\n1.Add new Customer" +
                                  "\n2.Customer View All Product/Toy List" +
                                  "\n3.Buy New toys" +
                                  "\n4.Place Order and give payment"+
                                  "\n5.Exit");
                var num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        ToyCompany.AddNewCustomerDetail();
                        break;
                    case 2:
                        ToyCompany.viewAllProdutList();
                        break;
                    case 3:
                        ToyCompany.BuyNewToys();
                        break;
                    case 4:
                        ToyCompany.PlaceOrderAndGivePayment();
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
