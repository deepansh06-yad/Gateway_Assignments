using Business.Interface;
using Entities.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Mechanicmanager : IMechanicmanager
    {
        private readonly IMechanicRepo _dbcontext;
        public Mechanicmanager(IMechanicRepo dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string CreateMechanic(Mechanicmodel model)
        {
            return _dbcontext.CreateMechanic(model);
        }

        public string DeleteMechanic(int Id)
        {
            return _dbcontext.DeleteMechanic(Id);
        }

        public List<Mechanicmodel> GetallMechanic()
        {
            return _dbcontext.GetallMechanic();
        }

        public Mechanicmodel GetMechanicyId(int Id)
        {
            return _dbcontext.GetMechanicyId(Id);
        }

        public string UpdateMechanic(Mechanicmodel model)
        {
            return _dbcontext.UpdateMechanic(model); 
        }
    }
}
