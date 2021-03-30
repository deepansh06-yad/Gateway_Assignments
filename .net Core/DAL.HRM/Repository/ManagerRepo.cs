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
    public class ManagerRepo : IManagerRepo
    {
        private readonly DataContext _context;
        
        public ManagerRepo(DataContext context)
        {
            _context = context;
            
        }
        public string Create(ManagerModel model)
        {
            if (model!=null)
            {
                Managers manager = new Managers();
                manager.Manager = model.Manager;
                _context.Managers.Add(manager);
                _context.SaveChanges();
                return "Manager created Successfully";
            }

            return "";
        }

        public string Delete(int Id)
        {
            var manager = _context.Managers.Find(Id);
            if (manager!=null)
            {
                var entities = _context.Entry(manager);
                entities.State = EntityState.Deleted;
                _context.SaveChanges();
                return "Deleted Successfully";
            }

            return "Manager not found";
        }

        public ManagerModel GetManagerById(int Id)
        {
            var managers = _context.Managers.Find(Id);
            ManagerModel manager = new ManagerModel();
            if (managers!=null)
            {
                manager.Id = managers.Id;
                manager.Manager = managers.Manager;
            }
            return manager;
        }

        public List<ManagerModel> GetManagers()
        {
            var entity = _context.Managers.ToList();
            List<ManagerModel> managers = new List<ManagerModel>();
            if (entity!=null)
            {
                foreach (var item in entity)
                {
                    ManagerModel manager = new ManagerModel();
                    manager.Id = item.Id;
                    manager.Manager = item.Manager;
                    managers.Add(manager);
                }
            }
            return managers;
        }

        public string Update(int Id,ManagerModel model)
        {
            var manager = _context.Managers.Find(Id);
            if (model!=null)
            {
                var managers = _context.Entry(manager);
                managers.State = EntityState.Modified;
                
                _context.SaveChanges();
                return "Updated Successfully";
            }
            return "No user Found";
        }
    }
}
