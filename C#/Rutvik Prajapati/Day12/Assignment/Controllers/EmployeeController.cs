using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day12Task.API.Services.EmployeeServices;
using Day12Task.API.Model;

namespace Day12Task.API.Controllers
{
    [ApiController]
    [Route("api/emps")]
    [Produces("application/json")]
    public class EmployeeController : Controller
    {
        private IEmployeeServices _employeeServices;
        public EmployeeController(IEmployeeServices employeeServices)
        {
            this._employeeServices = employeeServices;
        }
        
        //create new employee
        [Route("createEmployee")]
        [HttpPost]
        public string CreateNewEmployee([FromBody]EmployeeModel employeeModel)
        {
            var response = "";
            try
            {
                if (employeeModel!=null)
                {
                    response = _employeeServices.addNewEmployee(employeeModel);
                    if (response == null)
                    {
                        return NotFound().ToString();
                    }   
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Get all employee list
        [Route("GetAllEmployee")]
        [HttpGet]
        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> response;
            try
            {
                response = _employeeServices.getEmployeeList();              
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //Get Employee Detail by EmployeeId
        [Route("GetEmployee/{employeeId}")]
        [HttpPost]
        public EmployeeModel GetEmployeesById(Int64 employeeId)
        {
            var response =  new EmployeeModel();
            try
            {
                if (employeeId != 0 && employeeId>0)
                {
                    response = _employeeServices.getEmployeeById(employeeId);
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
