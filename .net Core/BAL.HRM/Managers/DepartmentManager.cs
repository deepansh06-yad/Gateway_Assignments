using DAL.HRM.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.HRM.Managers
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartment _context;
        
        public DepartmentManager(IDepartment context)
        {
            _context = context;
        }
        public string Create(DepartmentModel model)
        {

            return _context.Create(model);
        }

        public string Delete(int Id)
        {
            return _context.Delete(Id);
        }

        public List<DepartmentModel> GetAllDepartment()
        {
            return _context.GetAllDepartment();
        }

        public DepartmentModel GetDepartment(int Id)
        {
            return _context.GetDepartment(Id);
        }

        public string Update(DepartmentModel model)
        {
            return _context.Update(model);
        }
    }
}
