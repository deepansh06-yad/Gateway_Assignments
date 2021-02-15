using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Web.Security;

namespace Entities.Repository
{
    public class CustomerRegisterRepo : ICusttomerRegisterRepo
    {
        private readonly Database.GarageEntities _dbcontext;
        public CustomerRegisterRepo()
        {
            _dbcontext = new Database.GarageEntities();
        }
        public string CreateCustomer(Customermodel model)
        {
            try
            {
                if (model!=null)
                {
                    Database.Customer entity = new Database.Customer();
                    entity.Name = model.Name;
                    entity.Address = model.Address;
                    entity.Locality = model.Locality;
                    entity.Email = model.Email;
                    entity.Mobile = model.Mobile;
                    entity.Home = model.Home;
                    entity.Note = model.Note;
                    entity.Password = model.Password;
                    entity.Pincode = model.Pincode;
                    _dbcontext.Customers.Add(entity);
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

        public string DeleteCustomer(int Id)
        {
            var entity = _dbcontext.Customers.Find(Id);
            if (entity!=null)
            {
                var entities = _dbcontext.Entry(entity);
                entities.State = EntityState.Deleted;
                _dbcontext.SaveChanges();
                return "";
            }
            return "";
        }

        public List<Customermodel> GetallCustomer()
        {

            var entities = _dbcontext.Customers.ToList();
            List<Customermodel> customerlist = new List<Customermodel>();
           
                if (entities != null)
                {
                    foreach (var item in entities)
                    {
                        Customermodel customermodel = new Customermodel();
                        customermodel.Name = item.Name;
                        customermodel.Address = item.Address;
                        customermodel.Locality = item.Locality;
                        customermodel.Email = item.Email;
                        customermodel.Mobile = item.Mobile;
                        customermodel.Home = item.Home;
                        customermodel.Note = item.Note;
                        customermodel.Password = item.Password;
                        customermodel.Pincode = item.Pincode;
                        customerlist.Add(customermodel);
                    }
                }
                return customerlist;
        }

        public Customermodel GetCustomerbyId(int id)
        {
            var entity = _dbcontext.Customers.Find(id);
            Customermodel customerdata = new Customermodel();
            if (entity!=null)
            {
                customerdata.Name = entity.Name;
                customerdata.Address = entity.Address;
                customerdata.Locality = entity.Locality;
                customerdata.Email = entity.Email;
                customerdata.Mobile = entity.Mobile;
                customerdata.Home = entity.Home;
                customerdata.Note = entity.Note;
                customerdata.Pincode = entity.Pincode;
                customerdata.Password = entity.Password;
            }
            return customerdata;
        }

       
        public string UpdateCustomer(int id,Customermodel model)
        {
            var entity = _dbcontext.Customers.Find(model.Id);
            if (model!=null)
            {
                entity.Name = model.Name;
                entity.Address = model.Address;
                entity.Locality = model.Locality;
                entity.Email = model.Email;
                entity.Mobile = model.Mobile;
                entity.Home = model.Home;
                entity.Note = model.Note;
                entity.Password = model.Password;
                entity.Pincode = model.Pincode;
                _dbcontext.SaveChanges();
               
            }
            return entity.ToString();
        }
    }
}
