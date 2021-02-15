using Business.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace User.Controllers
{
    [Authorize]
    public class VehicleController : Controller
    {
        private readonly IVehicleManager _dbcontext;
        public VehicleController(IVehicleManager dbcontext)
        {
            _dbcontext = dbcontext;
        }
        // GET: Vehicle
        public ActionResult Index()
        {
            //Convert the Session into int and getting the vehicle list for particular
            int UserId = Convert.ToInt32(Session["ActiveUser"]);
            var vehicles = _dbcontext.GetAllVehicle().Where(x => x.OwnerId == UserId);
            return View(vehicles);
        }
        // GET: Vehicle/{Id}
        public ActionResult GetVehicleById(int Id)
        {
            //Get the user by Id
            var data = _dbcontext.GetVehicleById(Id);
            return View(data);
        }
        // GET: Vehicle/Create
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST: Vehicle/{model}
        //Create Vehicle
        [HttpPost]
        public ActionResult Create(Vehiclemodel model)
        {
            //TODO:Convert session into int and ADD vehicle
            model.OwnerId= Convert.ToInt32(Session["ActiveUser"]);
            _dbcontext.AddVehicle(model);
            return RedirectToAction("Index","Vehicle");
        }
        // GET: Vehicle
        
        public ActionResult Edit(int Id)
        {
            //Get particular user data to edit
            //TODO:Call Vehicle By Id

            var data = _dbcontext.GetVehicleById(Id);
            return View(data);
        }
        // PUT: Vehicle/data
        public ActionResult Edit(Vehiclemodel model)
        {
            //TODO:Call Update Vehicle

            _dbcontext.UpdateVehicle(model);
            return RedirectToAction("Index", "Vehicle");
        }
        // DELETE: Vehicle/{Id}
        public ActionResult Delete(int Id)
        {
            _dbcontext.DeleteVehicle(Id);
            return RedirectToAction("Index", "Vehicle");
        }
    }
}