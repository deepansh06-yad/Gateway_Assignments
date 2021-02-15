using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public class BookingRepo : IBookingRepo
    {
        private readonly Database.GarageEntities _dbcontext;
        public BookingRepo()
        {
            _dbcontext = new Database.GarageEntities();
        }
        public string CreateService(Servicemodel model)
        {
            Database.Service services = new Database.Service();
            services.Name = model.Name;
            services.Duration = model.Duration;
            services.Active = model.Active;
            services.Description = model.Description;
            _dbcontext.Services.Add(services);
            _dbcontext.SaveChanges();
            return "";
        }

        public string DeleteService(int Id)
        {
            var entity = _dbcontext.Services.Find(Id);
            if (entity!=null)
            {
                var entities = _dbcontext.Entry(entity);
                entities.State = System.Data.Entity.EntityState.Deleted;
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public string Editservice(Servicemodel model)
        {
            var entity = _dbcontext.Services.Find(model.Id);
            if (model!=null)
            {
                entity.Name = model.Name;
                entity.Duration = model.Duration;
                entity.Active = model.Active;
                entity.Description = model.Description;
                _dbcontext.SaveChanges();
            }
            return entity.ToString();
        }

        public List<Servicemodel> GetallService()
        {

            var entities = _dbcontext.Services.ToList();
            List<Servicemodel> services = new List<Servicemodel>();
            if (entities!=null)
            {
                foreach (var item in entities)
                {
                    Servicemodel model = new Servicemodel();
                    model.Name = item.Name;
                    model.Duration = item.Duration;
                    model.Active = item.Active;
                    model.Description = item.Description;
                    services.Add(model);
                }
            }
            return services;
        }

        public Servicemodel GetServiceById(int Id)
        {
            var entity = _dbcontext.Services.Find(Id);
            Servicemodel model = new Servicemodel();
            if (entity!=null)
            {
                model.Name = entity.Name;
                model.Duration = entity.Duration;
                model.Active = entity.Active;
                model.Description = entity.Description;
            }
            return model;
        }
    }
}
