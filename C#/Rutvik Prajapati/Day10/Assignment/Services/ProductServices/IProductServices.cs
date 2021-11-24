using System;
using System.Collections.Generic;
using System.Text;
using Day10Task.Model;

namespace Day10Task.Services.ProductServices
{
    public interface IProductServices
    {
        List<ProductModel> getProductList();
        List<OrderListModel> getOrderItemList(int customerId);
    }
}
