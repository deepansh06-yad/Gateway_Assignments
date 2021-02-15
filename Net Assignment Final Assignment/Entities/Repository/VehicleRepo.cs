using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public class VehicleRepo : IVehicleRepo
    {
        private readonly Database.GarageEntities _dbcontext;
        public VehicleRepo()
        {
            _dbcontext = new Database.GarageEntities();
        }
        public string AddVehicle(Vehiclemodel model)
        {
            if (model!=null)
            {
                Database.Vehicle vehicledetail = new Database.Vehicle();
                vehicledetail.LicensePlate = model.LicensePlate;
                vehicledetail.Make = model.Make;
                vehicledetail.Model = model.Model;
                vehicledetail.RegistrationDate = model.RegistrationDate;
                vehicledetail.ChassisNo = model.ChassisNo;
                vehicledetail.OwnerName = model.OwnerName;
                vehicledetail.OwnerId = model.OwnerId;
                _dbcontext.Vehicles.Add(vehicledetail);
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public string DeleteVehicle(int Id)
        {
            var entity = _dbcontext.Vehicles.Find(Id);
            if (entity!=null)
            {
                var entities = _dbcontext.Entry(entity);
                entities.State = System.Data.Entity.EntityState.Deleted;
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<Vehiclemodel> GetAllVehicle()
        {
            var entities = _dbcontext.Vehicles.ToList();
            List<Vehiclemodel> vehicles = new List<Vehiclemodel>();
            if (entities!=null)
            {
                foreach (var item in entities)
                {
                    Vehiclemodel vehicledata = new Vehiclemodel();
                    vehicledata.LicensePlate = item.LicensePlate;
                    vehicledata.Make = item.Make;
                    vehicledata.Model = item.Model;
                    vehicledata.RegistrationDate = item.RegistrationDate;
                    vehicledata.ChassisNo = item.ChassisNo;
                    vehicledata.OwnerName = item.OwnerName;
                    vehicledata.OwnerId = item.OwnerId;
                    vehicles.Add(vehicledata);
                }
            }
            return vehicles;
        }

        public Vehiclemodel GetVehicleById(int Id)
        {
            var entity = _dbcontext.Vehicles.Find(Id);
            Vehiclemodel model = new Vehiclemodel();
            if (entity!=null)
            {
                model.LicensePlate = entity.LicensePlate;
                model.Make = entity.Make;
                model.RegistrationDate = entity.RegistrationDate;
                model.ChassisNo = entity.ChassisNo;
                model.OwnerName = entity.OwnerName;
                model.OwnerId = entity.OwnerId;
                
            }
            return model;
        }

        public string UpdateVehicle(Vehiclemodel model)
        {
            var entity = _dbcontext.Vehicles.Find(model.Id);
            if (entity!=null)
            {
                entity.LicensePlate = model.LicensePlate;
                entity.Make = model.Make;
                entity.RegistrationDate = model.RegistrationDate;
                entity.ChassisNo = model.ChassisNo;
                entity.OwnerName = model.OwnerName;
                entity.OwnerId = model.OwnerId;
                _dbcontext.SaveChanges();
            }
            return entity.ToString();
        }
    }
}
