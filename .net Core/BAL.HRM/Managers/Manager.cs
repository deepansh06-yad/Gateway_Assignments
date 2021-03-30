using DAL.HRM.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.HRM.Managers
{
    public class Manager : IManger
    {
        private readonly IManagerRepo _context;
        public Manager(IManagerRepo context)
        {
            _context = context;
        }
        public string Create(ManagerModel model)
        {
            return _context.Create(model);
        }

        public string Delete(int Id)
        {
            return _context.Delete(Id);
        }

        public ManagerModel GetManagerById(int Id)
        {
            return _context.GetManagerById(Id);
        }

        public List<ManagerModel> GetManagers()
        {
            return _context.GetManagers();
        }

        public string Update(int Id,ManagerModel model)
        {
            return _context.Update(Id,model);
        }
    }
}
