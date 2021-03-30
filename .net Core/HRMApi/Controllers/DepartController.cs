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
    public class DepartController : ControllerBase
    {
        private readonly IDepartmentManager _context;
        public DepartController(IDepartmentManager context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateDepartment(DepartmentModel model)
        {
            var depart= _context.Create(model);
            return Ok(depart);
        }
        [HttpGet]
        public IActionResult GetDepartments()
        {
            List<DepartmentModel> li= _context.GetAllDepartment();
            return Ok(li);
        }
        [HttpGet("{Id}")]
        public IActionResult GetDepartmentById(int Id)
        {
            var data= _context.GetDepartment(Id);
            return Ok(data);
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteDepartment(int Id)
        {
            var data = _context.Delete(Id);
            return Ok(data);
        }
        [HttpPut]
        public IActionResult UpdateDepartment([FromBody] DepartmentModel model)
        {
            var data = _context.Update(model);
            return Ok(data);
        }

    }
}
