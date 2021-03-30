using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.HRM.Repository
{
    public interface IManagerRepo
    {
        ManagerModel GetManagerById(int Id);
        List<ManagerModel> GetManagers();
        string Update(int Id,ManagerModel model);
        string Delete(int Id);
        string Create(ManagerModel model);
    }
}
