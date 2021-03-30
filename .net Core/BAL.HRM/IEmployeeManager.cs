using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.HRM
{
    public interface IEmployeeManager
    {
        EmployeeModel GetEmployeeById(int Id);
        List<EmployeeModel> GetallEmployee();
        string CreateEmployee(EmployeeModel model);
        string UpdateEmployee(int Id,EmployeeModel model);
        string DeleteEmployee(int Id);
    }
}
