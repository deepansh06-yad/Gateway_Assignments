using GarageEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageApi.Services
{
    public class GarageServices
    {
        public List<GarageName> GetallGraages()
        {
            var garages = new List<GarageName>();
            for (int i = 1; i <=7 ; i++)
            {
                garages.Add(new GarageName
                {
                    Id = i,
                    Name=$"Garage_{i}",
                    Address=new Address
                    {
                        Id = i,
                        Street = $"Street_{i}",
                        Number = i,
                        City = $"City_{i}",
                        State = $"State_{i}",
                        Zip = $"Zip_{i}",
                        Country = $"Country_{i}"
                    },
                    StaffMembers = i * 10
                }) ;
            }
            return garages;
        }


        public Garageservicemenu GetService(long Id)
        {
            var garage = GetallGraages().Find(r => r.Id == Id);
            var services = new Garageservicemenu()
            {
                Id = 1,
                Garagename = garage,
                GarageId = garage.Id
            };
            var names = new Garagename().GetGaragenames();
            for (int i = 0; i < names.Count; i++)
            {
                var name = names[i];
                services.Services.Add(new GarageService
                {
                    Id = name.Id,
                    Garage = name
                });
            }
            return services;
        }
    }
}
