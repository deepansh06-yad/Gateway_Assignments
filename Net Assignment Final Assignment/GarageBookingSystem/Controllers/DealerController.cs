using Business.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageBookingSystem.Controllers
{
    public class DealerController : Controller
    {
        private readonly IDealerManager _dbcontext;
        public DealerController(IDealerManager dbcontext)
        {
            _dbcontext = dbcontext;
        }
        // GET: Dealer
        public ActionResult Index()
        {
            List<Dealermodel> dealer = _dbcontext.GetAllDealer();
            return View(dealer);
        }
        public ActionResult GetbyId(int Id)
        {
            var dealer = _dbcontext.GetDealerById(Id);
            return View(dealer);
        }
        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Post(Dealermodel model)
        {
            _dbcontext.CreateDealer(model);
            return RedirectToAction("Index","Dealer");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var dealer = _dbcontext.GetDealerById(Id);
            return View(dealer);
        }
        [HttpPost]
        public ActionResult Edit(Dealermodel model)
        {
            _dbcontext.UpdateDealer(model);
            return RedirectToAction("Index", "Dealer");
        }
       
        public ActionResult Delete(int Id)
        {
            _dbcontext.DeleteDealer(Id);
            return RedirectToAction("Index", "Dealer");
        }
    }
}