using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public interface IBookingRepo
    {
        List<Servicemodel> GetallService();
        Servicemodel GetServiceById(int Id);
        string DeleteService(int Id);
        string Editservice(Servicemodel model);
        string CreateService(Servicemodel model);
    }
}
