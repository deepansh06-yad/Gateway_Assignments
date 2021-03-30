using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.HRM.Repository
{
    public interface IEmployeeRepo
    {
        EmployeeModel GetEmployeeById(int Id);
        List<EmployeeModel> GetallEmployee();
        string CreateEmployee(EmployeeModel model);
        string UpdateEmployee(int Id, EmployeeModel model);
        string DeleteEmployee(int Id);
    }
}
