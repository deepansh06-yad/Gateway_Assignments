using HRM.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Controllers
{
    public class AuthenticationController : Controller
    {
       
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(EmployeesModel reg)
        {
            return View();
        }
    }
}
