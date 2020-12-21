using SourceControlFinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SourceControlFinalAssignment.Controllers
{
    [AllowAnonymous]
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
            using (var context = new logindb())
            {
                bool isValid = context.Registrations.Any(x => x.UserName == reg.UserName && x.Password == reg.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(reg.UserName, false);
                    return RedirectToAction("Index", "userdetail");
                }
                ModelState.AddModelError("", "Invalid Credentials");
            }
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Registration reg)
        {
            using (var context = new logindb())
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