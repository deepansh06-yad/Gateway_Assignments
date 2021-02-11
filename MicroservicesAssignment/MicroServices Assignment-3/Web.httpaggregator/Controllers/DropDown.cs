using CommonEntities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.httpaggregator.Services;

namespace Web.httpaggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropDown : ControllerBase
    {
        public async Task<IEnumerable<DropDowndto>> GetGarages()
        {
            var garages=await HttpCall.GetRequest<List<DropDowndto>>("https://localhost:44369/Dropdown/GetGaragesname");
            var services= await HttpCall.GetRequest<List<DropDowndto>>("https://localhost:44369/Dropdown/Getservice");
            garages.AddRange(services);
            return garages;
        }
     }
}
