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
    public class DealerManager : IDealerManager
    {
        private readonly IDealerRepo _dbcontext;
        public DealerManager(IDealerRepo dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string CreateDealer(Dealermodel model)
        {
            return _dbcontext.CreateDealer(model);
        }

        public string DeleteDealer(int Id)
        {
            return _dbcontext.DeleteDealer(Id); 
        }

        public List<Dealermodel> GetAllDealer()
        {
            return _dbcontext.GetAllDealer();
        }

        public Dealermodel GetDealerById(int Id)
        {
            return _dbcontext.GetDealerById(Id);
        }

        public string UpdateDealer(Dealermodel model)
        {
            return _dbcontext.UpdateDealer(model);
        }
    }
}
