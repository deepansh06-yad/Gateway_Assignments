using Business.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageBookingSystem.Controllers
{
    public class CustomersController : Controller
    {
        
        private readonly ICreateCustomer _dbcontext;
        public CustomersController(ICreateCustomer dbcontext)
        {
            _dbcontext = dbcontext;
        }
        // GET: Customers
        public ActionResult Index()
        {
           List<Customermodel> li= _dbcontext.GetallCustomer();
            if (li != null)
            {
                return View(li);
            }
            return View();
           
        }
        
        public ActionResult GetCustomerById(int Id)
        {
            var li= _dbcontext.GetCustomerbyId(Id);
            return View(li);
        }
        [HttpGet]
        public ActionResult RegisterCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterCustomer(Customermodel model)
        {
             _dbcontext.CreateCustomer(model);
            return RedirectToAction("Index","Customers");
        }
        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            var li= _dbcontext.GetCustomerbyId(id);
            return View(li);
        }
        [HttpPost]
        public ActionResult EditCustomer(int id,Customermodel model)
        {
            _dbcontext.UpdateCustomer(id,model);
           return  RedirectToAction("Index","Customers");
        }
        public ActionResult DeleteCustomer(int id)
        {
            _dbcontext.DeleteCustomer(id);
            return RedirectToAction("Index","Customers");
        }
        
    }
}