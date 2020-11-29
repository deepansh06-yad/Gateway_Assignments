using SourceControlAssignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SourceControlAssignment1.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult submitdata(employee emp)
        {
            if (ModelState.IsValid)
            {
                ViewBag.id = emp.id;
                ViewBag.firstname = emp.firstname;
                ViewBag.lastname = emp.lastname;
                ViewBag.age = emp.Age;
                ViewBag.hiredate = emp.hiredate;
                ViewBag.phone = emp.phone;
                ViewBag.email = emp.email;
                ViewBag.confirmmail = emp.confirmmail;
                return View("Index");
            }
            else
            {
                ViewBag.id = "no data found";
                ViewBag.firstname = "No data found";
                ViewBag.lastname = "No data found";
                ViewBag.hiredate = "no data found";
                ViewBag.phone = "no data found";
                ViewBag.email = "no data found";
                ViewBag.confirmmail = "no data found";
                ViewBag.age = "no data found";
                return View("Index");
            }
        }
        }
}