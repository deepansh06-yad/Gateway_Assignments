using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement.Controllers
{
    [Authorize]
    [Route("Dashboard/user")]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult user()
        {
            return View();
        }
    }
}