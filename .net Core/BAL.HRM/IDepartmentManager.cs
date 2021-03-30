using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.HRM
{
    public interface IDepartmentManager
    {
        List<DepartmentModel> GetAllDepartment();
        DepartmentModel GetDepartment(int Id);
        string Update(DepartmentModel model);
        string Delete(int Id);
        string Create(DepartmentModel model);
    }
}
