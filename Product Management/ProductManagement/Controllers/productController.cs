using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.IO;
using log4net;

namespace ProductManagement.Controllers
{
    [Authorize]
    public class productController : Controller
    {
        ProductdbEntities db = new ProductdbEntities();
        //making ienumerable object of productmodel
        IEnumerable<Productslist> productlist;
        public static readonly ILog log = LogManager.GetLogger(typeof(productController));
        // GET: product
        public ActionResult Index(int? page, string searchString,string sortby)
        {

          //  productmodel db = new productmodel();
          
            
            HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Productslists").Result;
            //storing response coming back from api
            productlist = response.Content.ReadAsAsync<IEnumerable<Productslist>>().Result;
            log.Info("Data store into the object");
            //searching the string according to name 
            ViewBag.Sortnameparameter = string.IsNullOrEmpty(sortby) ? "Name desc" : "";
            ViewBag.Sortcategoryparameter = sortby == "Category" ? "Category desc" : "Category";
            productlist = db.Productslists.AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
            {
                productlist = productlist.Where(s => s.Name.Contains(searchString)
                                       || searchString == null);

            }
            switch (sortby)
            {
                case "Name desc":
                    productlist = productlist.OrderByDescending(x => x.Name);
                    break;
                case "Category desc":
                    productlist = productlist.OrderByDescending(x => x.Category1.CategoryName);
                    break;
                default:
                    productlist = productlist.OrderBy(x => x.Name);
                    break;
            }
            return View(productlist);
    
        }
        public ActionResult CreateorEdit(int id=0)
        {
            //forusing category as dropdown list
            List<Category> productlist;
            HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Categories").Result;
            productlist = response.Content.ReadAsAsync<List<Category>>().Result;
            TempData["Category"] = new SelectList(productlist, "Id", "CategoryName");
           
            //if id==0 the the insert operation will call
            if (id == 0)
            {
               
                return View(new Productslist());
            }
           
            //if the id!=0 then the edit method will be called
           // log.Info("Data is Edied and back store into the database");
            else
            {
                 response = GlobalVariables.webapiclient.GetAsync("Productslists/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<Productslist>().Result);
            }
           
        }
        [HttpPost]
        public ActionResult CreateorEdit(Productslist product)
        {


          
                Productslist obj = new Productslist();
                obj.Id = product.Id;
                obj.Name = product.Name;
                obj.Price = product.Price;
                obj.Quantity = product.Quantity;
                string filename = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                string extension = Path.GetExtension(product.ImageFile.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                product.ImagePath = "~/Image/" + filename;
                filename = Path.Combine(Server.MapPath("~/Image/"), filename);
                product.ImageFile.SaveAs(filename);
                //ModelState.Clear();
                obj.ImagePath = product.ImagePath;
                obj.ShortDescription = product.ShortDescription;
                obj.Detaildescription = product.Detaildescription;
                obj.Category = product.Category;

                if (product.Id == 0)
                {

                    //sending data to the api 
                    HttpResponseMessage response = GlobalVariables.webapiclient.PostAsJsonAsync("Productslists", obj).Result;
                    TempData["SuccessMessage"] = "Saved Succesfully";

                    log.Info("Data is store into the database");
                }
                else
                {
                    //getting back the data for edit
                    HttpResponseMessage response = GlobalVariables.webapiclient.PutAsJsonAsync("Productslists/" + product.Id, obj).Result;
                    TempData["SuccessMessage"] = "Updated Succesfully";
                }
            
            HttpResponseMessage responses = GlobalVariables.webapiclient.GetAsync("Productslists").Result;
            productlist = responses.Content.ReadAsAsync<IEnumerable<Productslist>>().Result;
            return View("Index", productlist);

          
            }
       
        public ActionResult Delete(int id)
        {
            log.Info("Data is deleted");
            //it will delete the data as per the ID
            HttpResponseMessage response = GlobalVariables.webapiclient.DeleteAsync("Productslists/" + id.ToString()).Result;
            TempData["DeleteMessage"] = "Deleted Succesfully";
            log.Warn("Data is deleted");
            return RedirectToAction("Index");
        }
        public ActionResult Deletemultipledata(IEnumerable<int> id)
        {
            var list = db.Productslists.Where(x => id.Contains(x.Id)).ToList();
            foreach (Productslist item in list)
            {
                db.Productslists.Remove(item);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}