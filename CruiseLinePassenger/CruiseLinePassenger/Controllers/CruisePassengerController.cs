using BAL.Interface;
using DAL.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CruiseLinePassenger.Controllers
{
    public class CruisePassengerController : ApiController
    {
        private readonly ICruiseManager _dbcontext;
        private ICruiseRepo @object;

        public CruisePassengerController(ICruiseManager dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public CruisePassengerController(ICruiseRepo @object)
        {
            this.@object = @object;
        }

        // GET: api/CruisePassenger
        public IHttpActionResult Get()
        {
            List < CruisePassengermodel > cruisePassengerlist= _dbcontext.GetCruisePassengersList();
            return Ok(cruisePassengerlist);
        }

        // GET: api/CruisePassenger/5
        public HttpResponseMessage Get(int id)
        {
            var passengers = _dbcontext.GetCruisePassengerById(id);
            return Request.CreateResponse<CruisePassengermodel>(HttpStatusCode.OK,passengers);
        }

        // POST: api/CruisePassenger
        public string  Post([FromBody]CruisePassengermodel model)
        {
            return _dbcontext.CreatePassenger(model);
        }

        // PUT: api/CruisePassenger/5
        public string Put([FromBody]CruisePassengermodel model)
        {
            return _dbcontext.UpdatePassenger(model);
        }

        // DELETE: api/CruisePassenger/5
        public string Delete(int id)
        {
            return _dbcontext.DeletePassenger(id);
        }
    }
}
