using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using WebApi.Models;
using System.IO;
using log4net;

namespace WebApi.Controllers
{
    public class ProductslistsController : ApiController
    {
        private ProductdbEntities db = new ProductdbEntities();

       
        // GET: api/Productslists
        public IQueryable<Productslist> GetProductslists()
        {
            return db.Productslists;
         
        }


        // GET: api/Productslists/5
        [ResponseType(typeof(Productslist))]
        public IHttpActionResult GetProductslist(int id)
        {
            Productslist productslist = db.Productslists.Find(id);
            if (productslist == null)
            {
                return NotFound();
            }

            return Ok(productslist);
        }

        // PUT: api/Productslists/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductslist(int id, Productslist productslist)
        {

            if (id != productslist.Id)
            {
                return BadRequest();
            }
            
            db.Entry(productslist).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductslistExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

                
            }
            
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Productslists
        [ResponseType(typeof(Productslist))]
        public IHttpActionResult PostProductslist(Productslist productslist)
        {
           

            db.Productslists.Add(productslist);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = productslist.Id }, productslist);
        }
      

        // DELETE: api/Productslists/5
        [ResponseType(typeof(Productslist))]
        public IHttpActionResult DeleteProductslist(int id)
        {
            Productslist productslist = db.Productslists.Find(id);
            if (productslist == null)
            {
                return NotFound();
            }

            db.Productslists.Remove(productslist);
        
            db.SaveChanges();

            return Ok(productslist);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductslistExists(int id)
        {
            return db.Productslists.Count(e => e.Id == id) > 0;
        }
    }
}