using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProductManagement.Controllers
{
    public class AuthenticateController : Controller
    {
        // GET: Authenticate
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Registration reg)
        {
            using (var context = new ProductdbEntities())
            {
                bool isValid = context.Registrations.Any(x => x.Username == reg.Username && x.Password == reg.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(reg.Username, false);
                    return RedirectToAction("user", "Dashboard");
                }
                ModelState.AddModelError("", "Invalid Credentials");
            }
            return View();
        }
        public ActionResult LogOn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogOn(Registration reg)
        {
            using (var context = new ProductdbEntities())
            {
                context.Registrations.Add(reg);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}