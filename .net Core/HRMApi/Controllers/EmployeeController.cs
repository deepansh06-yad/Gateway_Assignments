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
        private readonly IEmployeeManager _context;
        public EmployeeController(IEmployeeManager context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetEmployees()
        {
            List<EmployeeModel> employee = _context.GetallEmployee();
            return Ok(employee);
        }
        [HttpGet("{Id}")]
        public IActionResult GetEmployeeById(int Id)
        {
            var employee = _context.GetEmployeeById(Id);
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult CreateEmployee([FromBody]EmployeeModel model)
        {
            var employee = _context.CreateEmployee(model);
            return Ok(employee);
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteEmployee(int Id)
        {
            var employee = _context.DeleteEmployee(Id);
            return Ok(employee);
        }
        [HttpPut("{Id}")]
        public IActionResult UpdateEmployee(int Id,[FromBody]EmployeeModel model)
        {
            var emp = _context.UpdateEmployee(Id,model);
            return Ok(emp);
        }
    }
}
