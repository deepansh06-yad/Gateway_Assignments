using GarageApi.Services;
using GarageEntities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarageService : ControllerBase
    {
        [HttpGet, Route("GetGaragesname")]
        public IEnumerable<Garage> GetGaragesname()
        {
            return (IEnumerable<Garage>)new Garagename().GetGaragenames();
        }
    }
}
