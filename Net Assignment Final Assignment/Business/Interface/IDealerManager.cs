using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IDealerManager
    {
        List<Dealermodel> GetAllDealer();
        Dealermodel GetDealerById(int Id);
        string UpdateDealer(Dealermodel model);
        string CreateDealer(Dealermodel model);
        string DeleteDealer(int Id);
    }
}
