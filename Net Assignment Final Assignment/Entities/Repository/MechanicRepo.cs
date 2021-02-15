using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public class MechanicRepo : IMechanicRepo
    {
        private readonly Database.GarageEntities _dbcontext;
        public MechanicRepo()
        {
            _dbcontext = new Database.GarageEntities();
        }
        public string CreateMechanic(Mechanicmodel model)
        {
            try
            {
                if (model!=null)
                {
                    Database.Mechanic mechanicdetail = new Database.Mechanic();
                   
                    mechanicdetail.Name = model.Name;
                    mechanicdetail.Mobile = model.Mobile;
                    mechanicdetail.Email = model.Email;
                    _dbcontext.Mechanics.Add(mechanicdetail);
                    _dbcontext.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return "";
        }

        public string DeleteMechanic(int Id)
        {
            var entity = _dbcontext.Mechanics.Find(Id);
            if (entity!=null)
            {
                var entities = _dbcontext.Entry(entity);
                entities.State = EntityState.Deleted;
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<Mechanicmodel> GetallMechanic()
        {
            var entities = _dbcontext.Mechanics.ToList();
            List<Mechanicmodel> mechanicdata = new List<Mechanicmodel>();
            if (entities!=null)
            {
                foreach (var item in entities)
                {
                    Mechanicmodel mechanicmodels = new Mechanicmodel();
                    mechanicmodels.Id = item.Id;
                    mechanicmodels.Name = item.Name;
                    mechanicmodels.Mobile = item.Mobile;
                    mechanicmodels.Email = item.Email;
                    mechanicdata.Add(mechanicmodels);
                }
            }
            return mechanicdata;
        }

        public Mechanicmodel GetMechanicyId(int Id)
        {
            var entity = _dbcontext.Mechanics.Find(Id);
            Mechanicmodel model = new Mechanicmodel();
            if (entity!=null)
            {
                model.Id = entity.Id;
                model.Name = entity.Name;
                model.Mobile = entity.Mobile;
                model.Email = entity.Email;

            }
            return model;
        }

        public string UpdateMechanic(Mechanicmodel model)
        {
            var entity = _dbcontext.Mechanics.Find(model.Id);
            if (model!=null)
            {
                entity.Name = model.Name;
                entity.Mobile = model.Mobile;
                entity.Email = model.Email;
                _dbcontext.SaveChanges();
            }
            return entity.ToString();
        }
    }
}
