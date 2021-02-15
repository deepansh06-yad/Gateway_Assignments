using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public class DealerRepo : IDealerRepo
    {
        private readonly Database.GarageEntities _dbcontext;
        public DealerRepo()
        {
            _dbcontext = new Database.GarageEntities();
        }
        public string CreateDealer(Dealermodel model)
        {
            if (model!=null)
            {
                Database.Dealer dealer = new Database.Dealer();
                dealer.Name = model.Name;
                dealer.Phone = model.Phone;
                dealer.Address = model.Address;
                dealer.Locality = model.Locality;
                dealer.Zip_Code = model.Zip_Code;
                dealer.Email = model.Email;
                _dbcontext.Dealers.Add(dealer);
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public string DeleteDealer(int Id)
        {
            var entity = _dbcontext.Dealers.Find(Id);
            if (entity!=null)
            {
                var entities = _dbcontext.Entry(entity);
                entities.State = EntityState.Deleted;
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<Dealermodel> GetAllDealer()
        {
            var entities = _dbcontext.Dealers.ToList();
            List<Dealermodel> dealerdata = new List<Dealermodel>();
            if (entities!=null)
            {
                foreach (var item in entities)
                {
                    Dealermodel model = new Dealermodel();
                    model.Name = item.Name;
                    model.Phone = item.Phone;
                    model.Address = item.Address;
                    model.Locality = item.Locality;
                    model.Zip_Code = item.Zip_Code;
                    model.Email = item.Email;
                    dealerdata.Add(model);
                }
            }
            return dealerdata;
        }

        public Dealermodel GetDealerById(int Id)
        {
            var entity = _dbcontext.Dealers.Find(Id);
            Dealermodel model = new Dealermodel();
            if (entity!=null)
            {
                model.Name = entity.Name;
                model.Phone = entity.Phone;
                model.Address = entity.Address;
                model.Locality = entity.Locality;
                model.Zip_Code = entity.Zip_Code;
                model.Email = entity.Email;
            }
            return model;
        }

        public string UpdateDealer(Dealermodel model)
        {
            var entity = _dbcontext.Dealers.Find(model.Id);
            if (model!=null)
            {
                entity.Name = model.Name;
                entity.Phone = model.Phone;
                entity.Address = model.Address;
                entity.Locality = model.Locality;
                entity.Zip_Code = model.Zip_Code;
                entity.Email = model.Email;
                _dbcontext.SaveChanges();
            }
            return entity.ToString();
        }
    }
}
