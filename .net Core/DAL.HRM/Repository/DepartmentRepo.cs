using AutoMapper;
using DAL.HRM.Database;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.HRM.Repository
{
    public class DepartmentRepo : IDepartment
    {
        private readonly DataContext _context;

        public DepartmentRepo(DataContext context)
        {
            _context = context;
           
        }
        public string Create(DepartmentModel model)
        {
            if (model!=null)
            {
                Departments entity = new Departments();
                
                entity.Department = model.Department;
                _context.Departments.Add(entity);
                _context.SaveChanges();
                return "Added successfully";
            }
            return "model is empty";
        }

        public string Delete(int Id)
        {
            var entity = _context.Departments.Find(Id);
            if (entity!=null)
            {
                var entities = _context.Entry(entity);
                entities.State = EntityState.Deleted;
                _context.SaveChanges();
                return "Deleted successfully";
            }
            return "Not Found";
        }

        public List<DepartmentModel> GetAllDepartment()
        {
            var entity = _context.Departments.ToList();
            List<DepartmentModel> departments = new List<DepartmentModel>();
            if (entity!=null)
            {
                foreach (var item in entity)
                {
                    DepartmentModel department = new DepartmentModel();
                    department.Id = item.Id;
                    department.Department = item.Department;
                    departments.Add(department);
                }
            }
            return departments;
        }

        public DepartmentModel GetDepartment(int Id)
        {
            var department = _context.Departments.Find(Id);
            DepartmentModel department1 = new DepartmentModel();
            if (department!=null)
            {
                department1.Id = department.Id;
                department1.Department = department.Department;
            }
            return department1;
        }

        public string Update(DepartmentModel model)
        {
            var department = _context.Departments.Find(model.Id);
            if (model!=null )
            {
                var managers = _context.Entry(department);
                managers.State = EntityState.Modified;
               
                _context.SaveChanges();
                return "Updated Successfully";
            }
            return "Model is empty";
        }
    }
}
