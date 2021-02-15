using Business.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace User.Controllers
{
   
    public class CustomerController : Controller
    {

        private readonly ICreateCustomer _dbcontext;
        public CustomerController(ICreateCustomer dbcontext)
        {
            _dbcontext = dbcontext;
        }
        [HttpGet]
        //GET: Customer
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        //POST: Customer/{data}
        [ValidateAntiForgeryToken]
        public ActionResult Login(Customermodel model)
        {
            bool isValid = _dbcontext.GetallCustomer().Any(x => x.Email == model.Email && x.Password == model.Password);
            if (isValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, false);
                Session["ActiveUser"] = _dbcontext.GetallCustomer().Where(x => x.Email == model.Email && x.Password == model.Password).First().Id;
                return RedirectToAction("Index", "Vehicle");
            }
            ModelState.AddModelError("", "Invalid Credential");

            return View();
        }
        //Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        //[Route{"Get"}]
        // GET: Customer
       
        [HttpGet]
        public ActionResult RegisterCustomer()
        {
            return View();
        }
        // POST: Customer
        [HttpPost]
        public ActionResult RegisterCustomer(Customermodel model)
        {
            _dbcontext.CreateCustomer(model);
            return RedirectToAction("Login", "Customer");
        }
     
        
    }
}