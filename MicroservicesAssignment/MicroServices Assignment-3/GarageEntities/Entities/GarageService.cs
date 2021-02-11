using System;
using System.Collections.Generic;
using System.Text;

namespace GarageEntities.Entities
{
    public class GarageService
    {
        public long Id { get; set; }
        public Garage Garage { get; set; }
    }
    public class Garageservicemenu
    {
        public Garageservicemenu()
        {
            Services = new List<GarageService>();
        }
        public long Id { get; set; }
        public long GarageId { get; set; }
        public GarageName Garagename { get; set; }
        public List<GarageService> Services { get; set; }
    }
}
