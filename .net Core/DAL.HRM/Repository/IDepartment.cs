using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.HRM.Repository
{
    public interface IDepartment
    {
        List<DepartmentModel> GetAllDepartment();
        DepartmentModel GetDepartment(int Id);
        string Update(DepartmentModel model);
        string Delete(int Id);
        string Create(DepartmentModel model);
    }
}
