using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public interface IDealerRepo
    {
        List<Dealermodel> GetAllDealer();
        Dealermodel GetDealerById(int Id);
        string UpdateDealer(Dealermodel model);
        string CreateDealer(Dealermodel model);
        string DeleteDealer(int Id);
    }
}
