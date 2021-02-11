using CommonEntities.Models;
using GarageApi.Services;
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
    public class DropDownmanager : ControllerBase
    {
        [HttpGet, Route("Getservices")]
        public IEnumerable<DropDowndto> Getservices()
        {
            return new Garagename().GetGaragenames().Select(r => new DropDowndto { Id = r.Id, Name = r.Name });
        }
        [HttpGet, Route("GetGarages")]
        public IEnumerable<DropDowndto> GetGarages()
        {
            return new GarageServices().GetallGraages().Select(r => new DropDowndto { Id = r.Id, Name = r.Name });
        }
    }
}
