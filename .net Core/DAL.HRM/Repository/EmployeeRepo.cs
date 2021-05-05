using DAL.HRM.Database;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.HRM.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DataContext _context;
        public EmployeeRepo(DataContext context)
        {
            _context = context;
        }
        public string CreateEmployee(EmployeeModel model)
        {
            if (model!=null)
            {
                Employees employee = new Employees();
                employee.Name = model.Name;
                employee.DepartmentId = model.DepartmentId;
                employee.Salary = model.Salary;
                employee.IsManager = model.IsManager;
                employee.ManagerId = model.ManagerId;
                employee.Phone = model.Phone;
                employee.Email = model.Email;
                employee.Password = model.Password;
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return "";
            }
            return "";
        }

        public string DeleteEmployee(int Id)
        {
            var employee = _context.Employees.Find(Id);
            if (employee!=null)
            {
                var entities = _context.Entry(employee);
                entities.State = EntityState.Deleted;
                
                _context.SaveChanges();
                return "Deleted Successfully";
            }
            return "Employee not Found";
        }

        public List<EmployeeModel> GetallEmployee()
        {
            var employees = _context.Employees.ToList();
            List<EmployeeModel> employeelist = new List<EmployeeModel>();
            if (employees!=null)
            {
                foreach (var item in employees)
                {
                    EmployeeModel employee = new EmployeeModel();
                    employee.Id = item.Id;
                    employee.Name = item.Name;
                    employee.DepartmentId = item.DepartmentId;
                    employee.Salary = item.Salary;
                    employee.IsManager = item.IsManager;
                    employee.ManagerId = item.ManagerId;
                    employee.Phone = item.Phone;
                    employee.Email = item.Email;
                    employeelist.Add(employee);
                }
            }
            return employeelist;
        }

        public EmployeeModel GetEmployeeById(int Id)
        {
            var employee = _context.Employees.Find(Id);
            EmployeeModel employees = new EmployeeModel();
            if (employee!=null)
            {
                employees.Name = employee.Name;
                employees.DepartmentId = employee.DepartmentId;
                employees.Salary = employee.Salary;
                employees.IsManager = employee.IsManager;
                employees.ManagerId = employee.ManagerId;
                employees.Phone = employee.Phone;
                employees.Email = employee.Email;
               
            }
            return employees;
        }

        public string UpdateEmployee(int Id,EmployeeModel model)
        {
            var employees = _context.Employees.Find(Id);
            if (model!=null)
            {
                employees.Name = model.Name;
                employees.DepartmentId = model.DepartmentId;
                employees.Salary = model.Salary;
                employees.IsManager = model.IsManager;
                employees.ManagerId = model.ManagerId;
                employees.Phone = model.Phone;
                employees.Email = model.Email;
                employees.Password = model.Password;
                _context.SaveChanges();
                return "Employee is updated successfully";
            }
            return "Model is empty";
        }
    }
}
