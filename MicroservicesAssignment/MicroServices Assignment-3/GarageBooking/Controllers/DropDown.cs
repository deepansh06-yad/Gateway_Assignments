using CommonEntities.Models;
using GarageBooking.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropDown : ControllerBase
    {
        [HttpGet, Route("GetBooking")]
        public IEnumerable<DropDowndto> GetBooking()
        {
            return new BookingService().GetBooks().Select(r => new DropDowndto { Id = r.Id, Name = r.Number });
        }
    }
}
