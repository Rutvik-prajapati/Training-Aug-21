using System;
using System.Collections.Generic;
using System.Text;
using Day11Task.API.Model;

namespace Day11Task.Services.ProductServices
{
    public interface IProductServices
    {
        List<ProductModel> getProductList();
        List<OrderListModel> getOrderItemList(int customerId);
    }
}
