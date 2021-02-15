using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class ProductslistsController : Controller
    {
        private ProductdbEntities db = new ProductdbEntities();

        // GET: Productslists
        public ActionResult Index()
        {
            var productslists = db.Productslists.Include(p => p.Category1);
            return View(productslists.ToList());
        }

        // GET: Productslists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productslist productslist = db.Productslists.Find(id);
            if (productslist == null)
            {
                return HttpNotFound();
            }
            return View(productslist);
        }

        // GET: Productslists/Create
        public ActionResult Create()
        {
            ViewBag.Category = new SelectList(db.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Productslists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Quantity,ImagePath,ShortDescription,Detaildescription,Category")] Productslist productslist)
        {
            if (ModelState.IsValid)
            {
                db.Productslists.Add(productslist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category = new SelectList(db.Categories, "Id", "CategoryName", productslist.Category);
            return View(productslist);
        }

        // GET: Productslists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productslist productslist = db.Productslists.Find(id);
            if (productslist == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category = new SelectList(db.Categories, "Id", "CategoryName", productslist.Category);
            return View(productslist);
        }

        // POST: Productslists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Quantity,ImagePath,ShortDescription,Detaildescription,Category")] Productslist productslist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productslist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category = new SelectList(db.Categories, "Id", "CategoryName", productslist.Category);
            return View(productslist);
        }

        // GET: Productslists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productslist productslist = db.Productslists.Find(id);
            if (productslist == null)
            {
                return HttpNotFound();
            }
            return View(productslist);
        }

        // POST: Productslists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Productslist productslist = db.Productslists.Find(id);
            db.Productslists.Remove(productslist);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
