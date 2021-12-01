using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.API.Model;

namespace TestProject.API.Services.EmployeeServices
{
    public interface IEmployeeServices
    {
        string AddEmployeeListOfData(List<EmployeeListModel> employeeListModels);
        string UpdateEmployeeListOfData(List<EmployeeListModel> employeeListModels);
        string DeleteEmployeeListOfData(List<EmployeeListModel> employeeListModels);
    }
}
