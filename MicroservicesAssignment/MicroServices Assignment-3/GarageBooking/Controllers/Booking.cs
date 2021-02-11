using BookingEntities;
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
    public class Booking : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Book> GetOrders()
        {
            return new BookingService().GetBooks();
        }
        [HttpGet, Route("GetBooking/{id}")]
        public IEnumerable<Book> GetBooking(long id)
        {
            return new BookingService().GetBooks(id: id);
        }
    }
}
