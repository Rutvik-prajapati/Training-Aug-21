using System;
using System.Collections.Generic;
using System.Text;
using Day10Task.Services.CustomerServices;
using Day10Task.Services.ProductServices;
using Day10Task.Model;

namespace Day10Task
{
    public class ToyCompany
    {
        private ICustomerServices _customerServices;
        private IProductServices _productServices;
        public ToyCompany(ICustomerServices customerServices)
        {
            this._customerServices = customerServices;
        }
        public ToyCompany(IProductServices productServices)
        {
            this._productServices = productServices;
        }
        public ToyCompany(ICustomerServices customerServices,IProductServices productServices)
        {
            this._customerServices = customerServices;
            this._productServices = productServices;
        }

        public static void AddNewCustomerDetail()
        {
            ICustomerServices customerServices = new CustomerServices();
            ToyCompany toyCompany = new ToyCompany(customerServices);

            CustomerDetail customerDetail = new CustomerDetail();
            Console.WriteLine("Enter new customer name:");
            customerDetail.Name = Console.ReadLine();
            Console.WriteLine("Enter customer Address Details");
            Console.WriteLine("Enter City name:");
            customerDetail.City = Console.ReadLine();
            Console.WriteLine("Enter District name:");
            customerDetail.District = Console.ReadLine();
            Console.WriteLine("Enter State name:");
            customerDetail.State = Console.ReadLine();
            var result = customerServices.addNewCustomer(customerDetail);
            Console.WriteLine(result);        
        }

        public static void viewAllProdutList()
        {
            IProductServices productServices = new ProductServices();
            ToyCompany toyCompany = new ToyCompany(productServices);

            var toyList = new List<ProductModel>();
            Console.WriteLine("Product/toy List Below:");
            toyList = productServices.getProductList();
            foreach (var toy in toyList)
            {
                Console.WriteLine($"ToyId:{toy.Id} ToyName:{toy.ToyName}");
            }
        }

        public static void BuyNewToys()
        {
            ICustomerServices customerServices = new CustomerServices();
            IProductServices productServices = new ProductServices();
            ToyCompany toyCompany = new ToyCompany(customerServices,productServices);

            var customerList = new List<CustomerListModel>();
            var toyList = new List<ProductModel>();
            var orderItem = new OrderListModel();
            Console.WriteLine("Customer List are below:");
            customerList = customerServices.getCustomerList();
            foreach (var customer in customerList)
            {
                Console.WriteLine($"Customer Id:{customer.CustomerId} Customer Name : {customer.CustomerName}");
            }
            Console.WriteLine("\nToys List are below:");
            toyList = productServices.getProductList();
            foreach (var toy in toyList)
            {
                Console.WriteLine($"ToyId:{toy.Id} ToyName:{toy.ToyName}");
            }
            Console.WriteLine("\nEnter Customer Id :");
            orderItem.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Toy Id :");
            orderItem.ToyId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHow many number of toys you want to buy:");
            orderItem.Quantity = Convert.ToInt32(Console.ReadLine());

            var result = customerServices.customerOrderItems(orderItem);
            Console.WriteLine(result);
        }

        public static void PlaceOrderAndGivePayment()
        {
            ICustomerServices customerServices = new CustomerServices();
            IProductServices productServices = new ProductServices();
            ToyCompany toyCompany = new ToyCompany(customerServices, productServices);

            var productItemList = new List<OrderListModel>();
            var customerList = new List<CustomerListModel>();
            Console.WriteLine("Customer List are below:");
            customerList = customerServices.getCustomerList();
            foreach (var customer in customerList)
            {
                Console.WriteLine($"Customer Id:{customer.CustomerId} Customer Name : {customer.CustomerName}");
            }
            Console.WriteLine("\nEnter Your Customer Id:");
            var customerId = Convert.ToInt32(Console.ReadLine());
            productItemList = productServices.getOrderItemList(customerId);
            int GrandTotal = 0;
            foreach (var item in productItemList)
            {
                Console.WriteLine($"CustomerId:{item.CustomerId} ToyName:{item.ToyName} Quantity:{item.Quantity} Total:{item.TotalPrice}");
                GrandTotal = GrandTotal + item.TotalPrice;
            }
            Console.WriteLine($"Grand Total:{GrandTotal}");
            
            Console.WriteLine("Enter Payment Value:");
            var payment = Convert.ToInt32(Console.ReadLine());
            var result = customerServices.customerPlaceOrder(customerId);
            Console.WriteLine(result);
        }
    }
}
