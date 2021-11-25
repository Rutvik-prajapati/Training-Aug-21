using Day11Task.API.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Day11Task.Models;
using Day11Task.Helper;
using System.Linq;

namespace Day11Task.Services.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        public ToyCompanyDbContext dbContext { get; set; }
        public CustomerServices(ToyCompanyDbContext toyCompanyDbContext)
        {
            this.dbContext = toyCompanyDbContext;
        }
        public string addNewCustomer(CustomerDetail customerDetail)
        {
            var newAddress = new Address()
            {
                City = customerDetail.City,
                District = customerDetail.District,
                State = customerDetail.State
            };
            dbContext.Addresses.Add(newAddress);
            dbContext.SaveChanges();
            //var addressId = newAddress.Id;   after savechanges you got newrecord Id

            var newCustomer = new Customer()
            {
                Name = customerDetail.Name,
                AddressId = newAddress.Id
            };
            dbContext.Customers.Add(newCustomer);
            dbContext.SaveChanges();
            return "Successfully add new customer detail";
        }

        public string customerOrderItems(OrderListModel orderListModel)
        {
                int price = dbContext.Toys.Where(x => x.Id == orderListModel.ToyId)
                    .Select(x => x.Price).FirstOrDefault();
                var ordersItem = new OrderItem()
                {
                    CustomerId = orderListModel.CustomerId,
                    ToyId = orderListModel.ToyId,
                    Quantity = orderListModel.Quantity,
                    Date = DateTime.Now,
                    TotalPrice = orderListModel.Quantity * price,
                    IsCount = false
                };
                dbContext.OrderItems.Add(ordersItem);
                dbContext.SaveChanges();
                return "Successfully add Order And OrderPrice:" + ordersItem.TotalPrice;

           

        }

        public string customerPlaceOrder(int customerId)
        {
            
                var customerOrders = dbContext.OrderItems
                                    .Where(x => x.CustomerId == customerId
                                    && x.Date.Date.Month == DateTime.Now.Month
                                    && x.Date.Date.Day == DateTime.Now.Day)
                                    .ToList();

                int GrandTotal = 0;
                foreach (var cutomerOrder in customerOrders)
                {
                    cutomerOrder.IsCount = true;
                    GrandTotal = GrandTotal + cutomerOrder.TotalPrice;
                }
                var Orders = new Order()
                {
                    CustomerId = customerId,
                    GrandTotal = GrandTotal,
                    Status = (int)Helper.OrdersStatus.Conformed
                };
                dbContext.Orders.Add(Orders);
                dbContext.SaveChanges();

                var payment = new Payment()
                {
                    OrderId = Orders.Id,
                    Status = (int)Helper.PaymentStatus.Success
                };
                dbContext.Payments.Add(payment);
                dbContext.SaveChanges();
                return "\nPayment Successfull And Place the Order";
           
        }

        public List<CustomerListModel> getCustomerList()
        {
            var customerList = new List<CustomerListModel>();
           
            customerList = dbContext.Customers.Select(x => new CustomerListModel()
            {
                CustomerId = x.Id,
                CustomerName = x.Name
            }).ToList();
            return customerList;
            
        }

        public string updateCustomerDetail(CustomerDetailsModal customerDetailsModal)
        {
            var customerDetail = dbContext.Customers.Where(x => x.Id == customerDetailsModal.CustomerId).FirstOrDefault();
            customerDetail.Name = customerDetailsModal.Name;
            dbContext.SaveChanges();

            var customerAddress = dbContext.Addresses.Where(x => x.Id == customerDetail.AddressId).FirstOrDefault();
            customerAddress.City = customerDetailsModal.City;
            customerAddress.District = customerDetailsModal.District;
            customerDetailsModal.State = customerDetailsModal.State;
            dbContext.SaveChanges();

            return "Successfully update customer details";
        }

        public string deleteCustomer(int customerId)
        {
            var customerDetail = dbContext.Customers.Where(x => x.Id == customerId).FirstOrDefault();
            customerDetail.IsDeleted = true;
            dbContext.SaveChanges();
            return "successfully delete customer";
        }
    }
}
