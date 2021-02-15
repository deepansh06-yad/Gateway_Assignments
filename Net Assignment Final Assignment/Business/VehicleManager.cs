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
    public class VehicleManager : IVehicleManager
    {
        private readonly IVehicleRepo _dbcontext;
        public VehicleManager(IVehicleRepo dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string AddVehicle(Vehiclemodel model)
        {
            return _dbcontext.AddVehicle(model);
        }

        public string DeleteVehicle(int Id)
        {
            return _dbcontext.DeleteVehicle(Id);
        }

        public List<Vehiclemodel> GetAllVehicle()
        {
            return _dbcontext.GetAllVehicle();
        }

        public Vehiclemodel GetVehicleById(int Id)
        {
            return _dbcontext.GetVehicleById(Id);
        }

        public string UpdateVehicle(Vehiclemodel model)
        {
            return _dbcontext.UpdateVehicle(model);
        }
    }
}
