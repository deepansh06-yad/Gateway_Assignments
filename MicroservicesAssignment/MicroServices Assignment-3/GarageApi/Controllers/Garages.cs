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
    public class Garages : ControllerBase
    {
        [HttpGet, Route("Getservice")]
        public IEnumerable<GarageName> Getservice()
        {
            return new GarageServices().GetallGraages();
        }
        [HttpGet, Route("GetGarageservicemenu")]
        public Garageservicemenu GetGarageservicemenu(long id)
        {
            return new GarageServices().GetService(id);
        }
    }
}
