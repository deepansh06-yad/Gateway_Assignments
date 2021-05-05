using HRM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Http;

namespace HRM.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ILogger<EmployeesController> _logger;
        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Return List of Employees with Data 
        /// </summary>
        [AddHeader("Deepansh","Yadav")]
        public IActionResult Index()
        {
            List<EmployeesModel> employees;
            HttpResponseMessage response = GlobalVariable.webapiclient.GetAsync("Employee").Result;
            employees = response.Content.ReadAsAsync<List<EmployeesModel>>().Result;
            return View(employees);
        }
        public IActionResult AddorEdit(int Id=0)
        {
            List<DepartmentsModel> department;
            List<ManagersModel> managers;
            HttpResponseMessage response = GlobalVariable.webapiclient.GetAsync("Depart").Result;
            department = response.Content.ReadAsAsync<List<DepartmentsModel>>().Result;
            TempData["Department"] = new SelectList(department,"Id","Department");
            response = GlobalVariable.webapiclient.GetAsync("Manager").Result;
            managers = response.Content.ReadAsAsync<List<ManagersModel>>().Result;
            TempData["Manager"] = new SelectList(managers, "Id", "Manager");
            if (Id==0)
            {
                return View(new EmployeesModel());
            }
            else
            {
                 response = GlobalVariable.webapiclient.GetAsync("Employee/" + Id.ToString()).Result;
                return View(response.Content.ReadAsAsync<EmployeesModel>().Result);
            }
        }
        /// <summary>
        /// AddorEdit Employee 
        /// </summary>
        [HttpPost]
        public IActionResult AddorEdit(EmployeesModel model)
        {
            if (model.Id==0)
            {
                HttpResponseMessage response = GlobalVariable.webapiclient.PostAsJsonAsync("Employee", model).Result;
                _logger.LogInformation("New Employee Added");
            }
            else
            {
                HttpResponseMessage response = GlobalVariable.webapiclient.PutAsJsonAsync("Employee/" + model.Id, model).Result;
                _logger.LogWarning("Employee is Updated");
            }
            return RedirectToAction("Index");
        }
        /// <summary>
        /// Delete Employee 
        /// </summary>
        public IActionResult DeleteEmployee(int id)
        {
            HttpResponseMessage response = GlobalVariable.webapiclient.DeleteAsync("Employee/" + id.ToString()).Result;
            _logger.LogWarning("Employee is Deleted");
            return RedirectToAction("Index");
        }
    }
}
