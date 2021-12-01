using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day12Task.API.Model;

namespace Day12Task.API.Services.EmployeeServices
{
    public interface IEmployeeServices
    {
        string addNewEmployee(EmployeeModel employeeModel);
        List<EmployeeModel> getEmployeeList();
        EmployeeModel getEmployeeById(Int64 employeeId);
        string updateEmployeeDetail(EmployeeModel employeeModel);
    }
}
