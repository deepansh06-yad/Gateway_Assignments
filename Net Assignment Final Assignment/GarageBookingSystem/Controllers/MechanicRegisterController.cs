using Business.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageBookingSystem.Controllers
{
    public class MechanicRegisterController : Controller
    {
        private readonly IMechanicmanager _ctx;
        public MechanicRegisterController(IMechanicmanager ctx)
        {
            _ctx = ctx;
        }
        // GET: MechanicRegister
        public ActionResult Index()
        {
            List<Mechanicmodel> mechanic = _ctx.GetallMechanic();
            return View(mechanic);
        }
        public ActionResult GetCustomerById(int Id)
        {
            var li = _ctx.GetMechanicyId(Id);
            return View(li);
        }
        [HttpGet]
        public ActionResult PostMechanic()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PostMechanic(Mechanicmodel model)
        {
            _ctx.CreateMechanic(model);
            return RedirectToAction("Index","MechanicRegister");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var li = _ctx.GetMechanicyId(Id);
            return View(li);
        }
        [HttpPost]
        public ActionResult Edit(Mechanicmodel model)
        {
            _ctx.UpdateMechanic(model);
            return RedirectToAction("Index","MechanicRegister");
        }
       
        public ActionResult Delete(int id)
        {
            _ctx.DeleteMechanic(id);
            return RedirectToAction("Index", "MechanicRegister");
        }
    }
}