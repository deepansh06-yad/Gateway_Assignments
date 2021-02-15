using Business.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace User.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingmanager _dbcontext;
        public BookingController(IBookingmanager dbcontext)
        {
            _dbcontext = dbcontext;
        }
        // GET: Booking
        public ActionResult Index()
        {
            
            var service = _dbcontext.GetallService();
            return View(service);
        }

        // GET: Booking/Details/5
        public ActionResult Details(int id)
        {
            //TODO: Call GetSericeById
            var data= _dbcontext.GetServiceById(id);
            return View(data);
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        [HttpPost]
        public ActionResult Create(Servicemodel model)
        {
            try
            {
                //TODO: Call createService 
                _dbcontext.CreateService(model);

                return RedirectToAction("Index","Booking");
            }
            catch
            {
                return View();
            }
        }

        // GET: Booking/Edit/5
        public ActionResult Edit(int id)
        {
            //TODO: Get service for particular Id
           var data= _dbcontext.GetServiceById(id);
            return View(data);
        }

        // POST: Booking/Edit/5
        [HttpPost]
        public ActionResult Edit(Servicemodel model)
        {
            try
            {
                // TODO: Add update logic here
                _dbcontext.Editservice(model);

                return RedirectToAction("Index","Booking");
            }
            catch
            {
                return View();
            }
        }

        // GET: Booking/Delete/5
        public ActionResult Delete(int id)
        {
            //TODO: Call Delete Method
            _dbcontext.DeleteService(id);
            return RedirectToAction("Index", "Booking");
        }

        
    }
}
