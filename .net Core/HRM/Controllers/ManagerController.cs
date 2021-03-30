using HRM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HRM.Controllers
{
    public class ManagerController : Controller
    {

        private readonly ILogger<ManagerController> _logger;
        public ManagerController(ILogger<ManagerController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Manager List
        /// </summary>
        /// <returns>Mangers List</returns>
        public IActionResult Index()
        {
            IEnumerable<ManagersModel> managers;
            HttpResponseMessage response = GlobalVariable.webapiclient.GetAsync("Manager").Result;
            managers = response.Content.ReadAsAsync<IEnumerable<ManagersModel>>().Result;
            _logger.LogInformation("List of Managers fetched");
            return View(managers);
        }
        public IActionResult CreateorEdit(int Id = 0)
        {
            if (Id==0)
            { 
                return View(new ManagersModel());
             }
            else
            {
                HttpResponseMessage respone = GlobalVariable.webapiclient.GetAsync("Manager/"+Id.ToString()).Result;
                return View(respone.Content.ReadAsAsync<ManagersModel>().Result);
            }
        }
        /// <summary>
        /// Add new Manager
        /// </summary>
        /// <returns>Mangers List</returns>
        [HttpPost]
        public IActionResult CreateorEdit(ManagersModel model)
        {
            if (model.Id==0)
            {
                HttpResponseMessage respone = GlobalVariable.webapiclient.PostAsJsonAsync("Manager", model).Result;
                _logger.LogInformation("New Manager Added");
            }
            else
            {
                HttpResponseMessage respone = GlobalVariable.webapiclient.PutAsJsonAsync("Manager/"+model.Id, model).Result;
                _logger.LogWarning("Manager Updated");
            }
            return RedirectToAction("Index");
        }
        /// <summary>
        /// Delete the Manager
        /// </summary>
        /// <returns>Mangers List</returns>
        public IActionResult Deletemanager(int id)
        {
            HttpResponseMessage response = GlobalVariable.webapiclient.DeleteAsync("Manager/" + id.ToString()).Result;
            _logger.LogWarning("Manager is Deleted");
            return RedirectToAction("Index");
        }
    }
}
