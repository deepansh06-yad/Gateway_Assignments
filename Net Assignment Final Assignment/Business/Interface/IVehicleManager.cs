using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IVehicleManager
    {
        List<Vehiclemodel> GetAllVehicle();
        Vehiclemodel GetVehicleById(int Id);
        string UpdateVehicle(Vehiclemodel model);
        string DeleteVehicle(int Id);
        string AddVehicle(Vehiclemodel model);
    }
}
