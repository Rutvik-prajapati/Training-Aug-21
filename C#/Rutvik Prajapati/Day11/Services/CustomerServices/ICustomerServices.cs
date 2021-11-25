using System;
using System.Collections.Generic;
using System.Text;
using Day11Task.API.Model;

namespace Day11Task.Services.CustomerServices
{
    public interface ICustomerServices
    {
        string addNewCustomer(CustomerDetail customerDetail);
        List<CustomerListModel> getCustomerList();
        string customerOrderItems(OrderListModel orderListModel);
        string customerPlaceOrder(int customerId);
        string updateCustomerDetail(CustomerDetailsModal customerDetailsModal);
        string deleteCustomer(int customerId);
    }
}
