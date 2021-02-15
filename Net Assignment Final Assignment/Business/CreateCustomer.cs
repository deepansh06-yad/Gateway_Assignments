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
    public class CreateCustomer : ICreateCustomer
    {
        private readonly ICusttomerRegisterRepo _dbcontext;
        public CreateCustomer(ICusttomerRegisterRepo dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public string DeleteCustomer(int Id)
        {
           return _dbcontext.DeleteCustomer(Id);
        }

        public List<Customermodel> GetallCustomer()
        {
            return _dbcontext.GetallCustomer();
        }

        public Customermodel GetCustomerbyId(int id)
        {
            return _dbcontext.GetCustomerbyId(id);
        }

      

        public string UpdateCustomer(int id,Customermodel model)
        {
            return _dbcontext.UpdateCustomer(id,model);
        }

   

        string ICreateCustomer.CreateCustomer(Customermodel model)
        {
            return _dbcontext.CreateCustomer(model);
        }
    }
}
