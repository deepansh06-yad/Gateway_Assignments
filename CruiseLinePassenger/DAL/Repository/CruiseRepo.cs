using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Database;

namespace DAL.Repository
{
    public class CruiseRepo : ICruiseRepo
    {
        private readonly Database.CruiseLineDbEntities _dbcontext;
        private readonly IMapper mapper;
        public CruiseRepo()
        {
            _dbcontext = new Database.CruiseLineDbEntities();
        }
        public string CreatePassenger(CruisePassengermodel model)
        {
            //var Config = new MapperConfiguration(mc=>mc.CreateMap<Passenger,CruisePassengermodel>());
            //var mapper = new Mapper(Config);
            //var passenger = mapper.Map<CruisePassengermodel>(model);
            // _dbcontext.Passengers.Add(passenger);
            if (model!=null)
            {
                Passenger passenger = new Passenger();
                passenger.FirstName = model.FirstName;
                passenger.LastName = model.LastName;
                passenger.Phone = model.Phone;
                _dbcontext.Passengers.Add(passenger);
                _dbcontext.SaveChanges();
                return "Passenger is added";
            }
            return "Model is empty";
        }

        public string DeletePassenger(int id)
        {
            var entity = _dbcontext.Passengers.Find(id);
            if (entity!=null)
            {
                _dbcontext.Passengers.Remove(entity);
                _dbcontext.SaveChanges();
                return "Deleted successfuly";
            }
            return "Entity is empty";
        }

        public CruisePassengermodel GetCruisePassengerById(int Id)
        {
            var entity = _dbcontext.Passengers.Find(Id);
            CruisePassengermodel passenger = new CruisePassengermodel();
            if (entity != null)
            {
                passenger.Id = entity.Id;
                passenger.FirstName = entity.FirstName;
                passenger.LastName = entity.LastName;
                passenger.Phone = entity.Phone;
            }
            //var Config = new MapperConfiguration(mc => mc.CreateMap<Passenger, CruisePassengermodel>());
            //var mapper = new Mapper(Config);
            //List<CruisePassengermodel> passenger = mapper.Map<List<CruisePassengermodel>>(entity);
            return passenger;
        }

        public List<CruisePassengermodel> GetCruisePassengersList()
        {
            var entities = _dbcontext.Passengers.ToList();
            var Config = new MapperConfiguration(mc => mc.CreateMap<Passenger, CruisePassengermodel>());
            var mapper = new Mapper(Config);
            List<CruisePassengermodel> model = mapper.Map<List<CruisePassengermodel>>(entities);
            //model.Add(entities);
            return model;
        }

        public string UpdatePassenger(CruisePassengermodel model)
        {
            var entity = _dbcontext.Passengers.Find(model.Id);
            if (entity!=null)
            {
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Phone = model.Phone;
                return "Passenger is updated";
            }
            return "Model is empty";
        }
    }
}
