using BAL.HRM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _employeemanager;
        public EmployeeController(IEmployeeManager employeemanager)
        {
            _employeemanager = employeemanager;
        }
        [HttpGet]
        public IActionResult GetEmployees()
        {
            List<EmployeeModel> employee = _employeemanager.GetallEmployee();
            return Ok(employee);
        }
        [HttpGet("{Id}")]
        public IActionResult GetEmployeeById(int Id)
        {
            var employee = _employeemanager.GetEmployeeById(Id);
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult CreateEmployee([FromBody]EmployeeModel model)
        {
            var employee = _employeemanager.CreateEmployee(model);
            return Ok(employee);
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteEmployee(int Id)
        {
            var employee = _employeemanager.DeleteEmployee(Id);
            return Ok(employee);
        }
        [HttpPut("{Id}")]
        public IActionResult UpdateEmployee(int Id,[FromBody]EmployeeModel model)
        {
            var emp = _employeemanager.UpdateEmployee(Id,model);
            return Ok(emp);
        }
    }
}
