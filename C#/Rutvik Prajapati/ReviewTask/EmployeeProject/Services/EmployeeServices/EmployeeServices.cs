using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.API.Model;
using TestProject.API.Models;

namespace TestProject.API.Services.EmployeeServices
{
    public class EmployeeServices : IEmployeeServices
    {
        public EmployeeDBContext dbContext { get; set; }
        public EmployeeServices(EmployeeDBContext employeeDBContext)
        {
            this.dbContext = employeeDBContext;
        }
        public string AddEmployeeListOfData(List<EmployeeListModel> employeeListModels)
        {
            if (employeeListModels != null)
            {
                foreach (var employee in employeeListModels)
                {
                    var newEmployee = new Employee()
                    {
                        //Id = employee.EmployeeId,
                        Name = employee.EmployeeName,
                        Address = employee.EmployeeAddress
                    };
                    dbContext.Employees.Add(newEmployee);
                    dbContext.SaveChanges();
                }
            }
            
            return "Success";
        }

        public string UpdateEmployeeListOfData(List<EmployeeListModel> employeeListModels)
        {
            foreach (var employee in employeeListModels)
            {
                var employeeDetail = dbContext.Employees.Where(x => x.Id == employee.EmployeeId).FirstOrDefault();
                employeeDetail.Name = employee.EmployeeName;
                employeeDetail.Address = employee.EmployeeAddress;
                dbContext.SaveChanges();
            }
            return "Successfully Update";
        }

        public string DeleteEmployeeListOfData(List<EmployeeListModel> employeeListModels)
        {
            foreach (var employee in employeeListModels)
            {
                var empDetail = dbContext.Employees.Where(x => x.Id == employee.EmployeeId).FirstOrDefault();
                empDetail.IsDelete = true;
                dbContext.SaveChanges();
            }
            return "Successfully delete list of employees";
        }
    }
}
