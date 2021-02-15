using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IMechanicmanager
    {
        List<Mechanicmodel> GetallMechanic();
        Mechanicmodel GetMechanicyId(int Id);
        string UpdateMechanic(Mechanicmodel model);
        string DeleteMechanic(int Id);
        string CreateMechanic(Mechanicmodel model);
    }
}
