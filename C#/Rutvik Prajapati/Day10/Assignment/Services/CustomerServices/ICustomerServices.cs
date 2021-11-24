using System;
using System.Collections.Generic;
using System.Text;
using Day10Task.Model;

namespace Day10Task.Services.CustomerServices
{
    public interface ICustomerServices
    {
        string addNewCustomer(CustomerDetail customerDetail);
        List<CustomerListModel> getCustomerList();
        string customerOrderItems(OrderListModel orderListModel);
        string customerPlaceOrder(int customerId);
    }
}
