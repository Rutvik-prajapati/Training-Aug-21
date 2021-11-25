using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day11Task.Services.CustomerServices;
using Day11Task.Services.ProductServices;
using Day11Task.API.Model;

namespace Day11Task.API.Controllers
{ 
    [ApiController]
    [Route("api/Customer")]
    [Produces("application/json")]
    public class CustomerController : Controller
    {
        private ICustomerServices _customerServices;
        private IProductServices _productServices;
        public CustomerController(ICustomerServices customerServices, IProductServices productServices)
        {
            this._customerServices = customerServices;
            this._productServices = productServices;
        }

        [Route("RegisterCustomer")]
        [HttpPost]
        public string AddNewCustomer([FromBody]CustomerDetailsModal customerDetail)
        {
            try
            {
                var response = "";
                if (customerDetail != null)
                {
                    response = _customerServices.updateCustomerDetail(customerDetail);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [Route("UpdateCustomer")]
        [HttpPost]
        public string UpdateCustomerDetail([FromBody] CustomerDetailsModal customerDetail)
        {
            try
            {
                var response = "";
                if (customerDetail != null)
                {
                    response = _customerServices.updateCustomerDetail(customerDetail);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [Route("DeleteCustomer")]
        [HttpPost]
        public string DeleteCustomerDetail(int customerId)
        {
            try
            {
                var response = "";
                if (customerId != 0 && customerId>0)
                {
                    response = _customerServices.deleteCustomer(customerId);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [Route("OrderItems")]
        [HttpPost]
        public string CustomerOrderItems([FromBody] OrderListModel orderListModel)
        {
            try
            {
                var response = "";
                if (orderListModel != null)
                {
                    response = _customerServices.customerOrderItems(orderListModel);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        [Route("~/api/customerList")]
        [HttpGet]
        public List<CustomerListModel> GetCustomerList()
        {
            try
            {
                var response = _customerServices.getCustomerList();
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Route("placeOrder")]
        [HttpPost]
        public string CustomerPlaceOrder(int customerId)
        {
            try
            {
                var response = "";
                if (customerId != 0 && customerId>0)
                {
                    response = _customerServices.customerPlaceOrder(customerId);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
