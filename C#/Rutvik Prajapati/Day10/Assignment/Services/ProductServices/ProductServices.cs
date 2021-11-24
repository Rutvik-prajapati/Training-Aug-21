using System;
using System.Collections.Generic;
using System.Text;
using Day10Task.Models;
using Day10Task.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Day10Task.Services.ProductServices
{
    public class ProductServices : IProductServices
    {
        public List<OrderListModel> getOrderItemList(int customerId)
        {
            var orderItemList = new List<OrderListModel>();
            using (var dbContext = new ToyCompanyDbContext())
            {
                orderItemList = dbContext.OrderItems.Join(
                                        dbContext.Toys,
                                        orderItem => orderItem.Id,
                                        toy => toy.Id,
                                        (OrderItem, toy) => new OrderListModel()
                                        {
                                            CustomerId = OrderItem.CustomerId,
                                            ToyName = toy.Name,
                                            Quantity = OrderItem.Quantity,
                                            TotalPrice = OrderItem.TotalPrice
                                        }
                                        ).Where(x=>x.CustomerId==customerId).ToList();
                return orderItemList;
            }
        }

        public List<ProductModel> getProductList()
        {
            var productList = new List<ProductModel>();
            using (var dbContext = new ToyCompanyDbContext())
            {
                productList = dbContext.Toys.Select(x=> new ProductModel()
                {
                    Id = x.Id,
                    ToyName = x.Name
                }).ToList();
                return productList;
            }
        }
    }
}
