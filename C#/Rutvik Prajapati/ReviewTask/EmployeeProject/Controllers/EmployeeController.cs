using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.API.Model;
using TestProject.API.Services.EmployeeServices;

namespace TestProject.API.Controllers
{
    [ApiController]
    [Route("api/Employee")]
    [Produces("application/json")]
    public class EmployeeController : Controller
    {
        private IEmployeeServices _employeeServices;
        public EmployeeController(IEmployeeServices employeeServices)
        {
            this._employeeServices = employeeServices;
        }

        [Route("~/api/EmployeeList")]
        [HttpPost]
        public string AddListOfEmployeeData([FromBody]List<EmployeeListModel> employeeListModels)
        {
            try
            {
                var response = "";
                if (employeeListModels != null)
                {
                    response = _employeeServices.AddEmployeeListOfData(employeeListModels);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        [Route("~/api/UpdateEmployeeList")]
        [HttpPost]
        public string UpdateListOfEmployeeData([FromBody] List<EmployeeListModel> employeeListModels)
        {
            try
            {
                var response = "";
                if (employeeListModels != null)
                {
                    response = _employeeServices.UpdateEmployeeListOfData(employeeListModels);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        [Route("~/api/DeleteEmployeeList")]
        [HttpPost]
        public string DeleteListOfEmployeeData([FromBody] List<EmployeeListModel> employeeListModels)
        {
            try
            {
                var response = "";
                if (employeeListModels != null)
                {
                    response = _employeeServices.DeleteEmployeeListOfData(employeeListModels);
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }
    }
}
