using BAL.Interface;
using DAL.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CruiseManager : ICruiseManager
    {
        private readonly ICruiseRepo _dbcontext;
        public CruiseManager(ICruiseRepo dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string CreatePassenger(CruisePassengermodel model)
        {
            return _dbcontext.CreatePassenger(model);
        }

        public string DeletePassenger(int id)
        {
            return _dbcontext.DeletePassenger(id);
        }

        public CruisePassengermodel GetCruisePassengerById(int Id)
        {
            return _dbcontext.GetCruisePassengerById(Id);
        }

        public List<CruisePassengermodel> GetCruisePassengersList()
        {
            return _dbcontext.GetCruisePassengersList();
        }

        public string UpdatePassenger(CruisePassengermodel model)
        {
            return _dbcontext.UpdatePassenger(model);
        }
    }
}
