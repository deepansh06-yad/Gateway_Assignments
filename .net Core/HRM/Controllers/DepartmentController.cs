using HRM.Header;
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
    public class DepartmentController : Controller
    {
        private readonly ILogger<DepartmentController> _logger;
        public DepartmentController(ILogger<DepartmentController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// List of Departments
        /// </summary>
        /// <returns></returns>
         [ServiceFilter(typeof(MyActionFilterAttribute))]
        public IActionResult Index()
        {
            IEnumerable<DepartmentsModel> departments;
            HttpResponseMessage response = GlobalVariable.webapiclient.GetAsync("Depart").Result;
            departments = response.Content.ReadAsAsync<IEnumerable<DepartmentsModel>>().Result;
            return View(departments);
        }

        public IActionResult AddorEdit(int Id=0)
        {
            if (Id==0)
            {
                return View(new DepartmentsModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariable.webapiclient.GetAsync("Depart/" + Id.ToString()).Result;
                return View(response.Content.ReadAsAsync<DepartmentsModel>().Result);
            }
           
        }
        /// <summary>
        /// Add new Department
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddorEdit([FromBody ]DepartmentsModel model)
        {
            if (model.Id==0)
            {
                HttpResponseMessage response = GlobalVariable.webapiclient.PostAsJsonAsync("Depart", model).Result;
            }
            else
            {
                HttpResponseMessage response = GlobalVariable.webapiclient.PutAsJsonAsync("Depart/" + model.Id, model).Result;
            }
            return RedirectToAction("Index");
        }
        /// <summary>
        /// Delete the department
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Deletedepartment(int id)
        {
            HttpResponseMessage response = GlobalVariable.webapiclient.DeleteAsync("Depart/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}
