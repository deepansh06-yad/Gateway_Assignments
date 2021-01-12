using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement.Controllers
{
    public class categoryController : Controller
    {
        // GET: category
        public ActionResult Index()
        {
            IEnumerable<Categorymodel> products;
            
            HttpResponseMessage webResponse = GlobalVariables.webapiclient.GetAsync("Categories").Result;
            products = webResponse.Content.ReadAsAsync<IEnumerable<Categorymodel>>().Result;
            return View(products);
        }
        public ActionResult CreateorEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Categorymodel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Categories/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<Categorymodel>().Result);
            }

        }
        [HttpPost]
        public ActionResult CreateorEdit(Categorymodel product)
        {
            if (product.Id == 0)
            {
                HttpResponseMessage response = GlobalVariables.webapiclient.PostAsJsonAsync("Categories", product).Result;
                TempData["SuccessMessage"] = "Saved Succesfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.webapiclient.PutAsJsonAsync("Categories/" + product.Id, product).Result;
                TempData["SuccessMessage"] = "Updated Succesfully";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.webapiclient.DeleteAsync("Categories/" + id.ToString()).Result;
            TempData["DeleteMessage"] = "Deleted Succesfully";
            return RedirectToAction("Index");
        }
    }
}