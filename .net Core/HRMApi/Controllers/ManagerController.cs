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
    public class ManagerController : ControllerBase
    {
        private readonly IManger _manager;
        public ManagerController(IManger manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public IActionResult GetManagers()
        {
            List<ManagerModel> managers = _manager.GetManagers();
            return Ok(managers);
        }
        [HttpGet("{Id}")]
        public IActionResult GetManagerById(int Id)
        {
            var data = _manager.GetManagerById(Id);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult CreateManager([FromBody]ManagerModel model)
        {
            var manager = _manager.Create(model);
            return Ok(manager);
        }
        [HttpPut("{Id}")]
        public IActionResult Updatemanager(int Id,[FromBody]ManagerModel model)
        {
            var data = _manager.Update(Id,model);
            return Ok(data);
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteManager(int Id)
        {
            var data = _manager.Delete(Id);
            return Ok(data);
        }
    }
}
