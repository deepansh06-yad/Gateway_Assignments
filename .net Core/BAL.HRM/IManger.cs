using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.HRM
{
    public interface IManger
    {
        ManagerModel GetManagerById(int Id);
        List<ManagerModel> GetManagers();
        string Update(int Id,ManagerModel model);
        string Delete(int Id);
        string Create(ManagerModel model);
    }
}
