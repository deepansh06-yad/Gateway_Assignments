using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public interface ICusttomerRegisterRepo
    {
        List<Customermodel> GetallCustomer();
        Customermodel GetCustomerbyId(int id);
        
        string UpdateCustomer(int id,Customermodel model);
        string DeleteCustomer(int Id);
        string CreateCustomer(Customermodel model);
       
    }
}
