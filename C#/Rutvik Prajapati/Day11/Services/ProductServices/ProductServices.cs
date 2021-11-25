using System;
using System.Collections.Generic;
using System.Text;
using Day11Task.Models;
using Day11Task.API.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Day11Task.Services.ProductServices
{
    public class ProductServices : IProductServices
    {
        public ToyCompanyDbContext dbContext { get; set; }
        public ProductServices(ToyCompanyDbContext toyCompanyDbContext)
        {
            this.dbContext = toyCompanyDbContext;
        }
        public List<OrderListModel> getOrderItemList(int customerId)
        {
            var orderItemList = new List<OrderListModel>();
            
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
                                        ).Where(x => x.CustomerId == customerId).ToList();
                return orderItemList;
            
        }

        public List<ProductModel> getProductList()
        {
            var productList = new List<ProductModel>();
            
                productList = dbContext.Toys.Select(x => new ProductModel()
                {
                    Id = x.Id,
                    ToyName = x.Name
                }).ToList();
                return productList;
           
        }
    }
}
