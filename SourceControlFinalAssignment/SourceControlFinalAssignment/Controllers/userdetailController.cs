using SourceControlFinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace SourceControlFinalAssignment.Controllers
{
    [Authorize]
    public class userdetailController : Controller
    {
        logindb db = new logindb();
        // GET: userdetail
        public static readonly ILog log = LogManager.GetLogger(typeof(userdetailController));
        public ActionResult Index()
        {
            return View(db.userregistrations.ToList());
        }

        //create the new user
        //HTTPGET
        public ActionResult Create()
        {
            return View();
        }

        // POST: userregistrations/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(userregistration userregistration)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.userregistrations.Add(userregistration);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                log.Info("Data is store");
                ModelState.Clear();
                return View(userregistration);
            }
            catch(NullReferenceException ex)
            {
                return View(ex);
            }
        }
        //Edit the user detail
        [HttpGet]
        public ActionResult Edit(int id)
        {
            userregistration user = db.userregistrations.Where(x => x.id == id).SingleOrDefault();
            return View(user);

        }
        [HttpPost]
        public ActionResult Edit(int id, userregistration user)
        {
            try
            {
                userregistration userdetail = db.userregistrations.Where(x => x.id == id).SingleOrDefault();
                userdetail.Name = user.Name;
                userdetail.Emailid = user.Emailid;
                userdetail.Address = user.Address;
                userdetail.Age = user.Age;
                userdetail.Designation = user.Designation;
                userdetail.Phone = user.Phone;
                db.SaveChanges();
                log.Info("Data edited");
                return RedirectToAction("Index");
              
            }
            catch (DbEntityValidationException ex)
            {
                log.Error("Db entity Exception", ex);
                return View(ex);
            }
            
        }
        //delete the user data from the database
        public ActionResult Delete(int id)
        {
            try
            {
                userregistration user = db.userregistrations.Where(x => x.id == id).SingleOrDefault();
                db.userregistrations.Remove(user);
                db.SaveChanges();
                log.Info("Data is deleted");
                return RedirectToAction("Index");
            }
            catch (NullReferenceException ex)
            {
                log.Error("Null Refrence Exception",ex);
                return View(ex);
            }
        }

    }
}