using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICruiseRepo
    {
        List<CruisePassengermodel> GetCruisePassengersList();
        CruisePassengermodel GetCruisePassengerById(int Id);
        string CreatePassenger(CruisePassengermodel model);
        string UpdatePassenger(CruisePassengermodel model);
        string DeletePassenger(int id);
    }
}
