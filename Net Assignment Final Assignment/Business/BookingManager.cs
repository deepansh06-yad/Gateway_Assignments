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
    public class BookingManager : IBookingmanager
    {
        private readonly IBookingRepo _dbcontext;
        public BookingManager(IBookingRepo dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string CreateService(Servicemodel model)
        {
            return _dbcontext.CreateService(model);
        }

        public string DeleteService(int Id)
        {
            return _dbcontext.DeleteService(Id);
        }

        public string Editservice(Servicemodel model)
        {
            return _dbcontext.Editservice(model);
        }

        public List<Servicemodel> GetallService()
        {
            return _dbcontext.GetallService();
        }

        public Servicemodel GetServiceById(int Id)
        {
            return _dbcontext.GetServiceById(Id);
        }
    }
}
