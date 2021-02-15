using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface ICreateCustomer
    {
        List<Customermodel> GetallCustomer();
        Customermodel GetCustomerbyId(int Id);
        
        string UpdateCustomer(int id,Customermodel model);
        string DeleteCustomer(int Id);
        string CreateCustomer(Customermodel model);
       
    }
}
