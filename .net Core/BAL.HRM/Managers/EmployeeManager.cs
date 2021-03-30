using DAL.HRM.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.HRM.Managers
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepo _context;
        public EmployeeManager(IEmployeeRepo context)
        {
            _context = context;
        }
        public string CreateEmployee(EmployeeModel model)
        {
            return _context.CreateEmployee(model);
        }

        public string DeleteEmployee(int Id)
        {
            return _context.DeleteEmployee(Id);
        }

        public List<EmployeeModel> GetallEmployee()
        {
            return _context.GetallEmployee();
        }

        public EmployeeModel GetEmployeeById(int Id)
        {
            return _context.GetEmployeeById(Id);
        }

        public string UpdateEmployee(int Id,EmployeeModel model)
        {
            return _context.UpdateEmployee(Id,model);
        }
    }
}
