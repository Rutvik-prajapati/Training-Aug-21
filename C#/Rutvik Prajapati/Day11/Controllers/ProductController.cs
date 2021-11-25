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
    [Route("api/product")]
    [Produces("application/json")]
    public class ProductController : Controller
    {
        private ICustomerServices _customerServices;
        private IProductServices _productServices;
        public ProductController(ICustomerServices customerServices, IProductServices productServices)
        {
            this._customerServices = customerServices;
            this._productServices = productServices;
        }

        [Route("~/api/productsList")]
        [HttpGet]
        public List<ProductModel> GetProductList()
        {
            try
            {
                var response = _productServices.getProductList();
                return response;
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
