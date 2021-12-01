using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day12Task.API.Model;
using Day12Task.API.Models;

namespace Day12Task.API.Services.EmployeeServices
{
    public class EmployeeServices : IEmployeeServices
    {
        public EmployeeDBContext dbContext { get; set; }
        public EmployeeServices(EmployeeDBContext employeeDBContext)
        {
            this.dbContext = employeeDBContext;
        }
        public string addNewEmployee(EmployeeModel employeeModel)
        {
            var newEmployee = new Employee()
            {
                FirstName = employeeModel.FirstName,
                LastName = employeeModel.LastName,
                City = employeeModel.City,
                Country = employeeModel.Country,
                AddressLine1 = employeeModel.AddressLine1
            };
            dbContext.Employees.Add(newEmployee);
            dbContext.SaveChanges();
            return "Successfully add new employee";
        }

        public List<EmployeeModel> getEmployeeList()
        {
            var employeesList = new List<EmployeeModel>();

            employeesList = dbContext.Employees.Select(x=> new EmployeeModel()
            {
                EmployeeId = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                City = x.City,
                Country = x.Country,
                AddressLine1 = x.AddressLine1
            }).ToList();
            return employeesList;
        }

        public EmployeeModel getEmployeeById(Int64 employeeId)
        {
            var employeeDetail = new EmployeeModel();

            employeeDetail = dbContext.Employees.Select(x => new EmployeeModel()
            {
                EmployeeId = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                City = x.City,
                Country = x.Country,
                AddressLine1 = x.AddressLine1
            }).Where(x=>x.EmployeeId == employeeId).FirstOrDefault();

            return employeeDetail;
        }

        public string updateEmployeeDetail(EmployeeModel employeeModel)
        {
            var employeeDetail = dbContext.Employees.Where(x => x.Id == employeeModel.EmployeeId).FirstOrDefault();
            employeeDetail.FirstName = employeeModel.FirstName;
            employeeDetail.LastName = employeeModel.LastName;
            employeeDetail.City = employeeModel.City;
            employeeDetail.Country = employeeModel.Country;
            employeeDetail.AddressLine1 = employeeModel.AddressLine1;
            dbContext.SaveChanges();
            return "Successfully update employee detail";
        }
    }
}
