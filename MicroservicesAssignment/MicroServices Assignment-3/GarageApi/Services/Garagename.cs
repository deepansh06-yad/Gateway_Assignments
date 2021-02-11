using GarageEntities.Entities;
using GarageEntities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarageApi.Services
{
    public class Garagename
    {
        public List<Garage> GetGaragenames()
        {
            var garages = new List<Garage>();
            for (int i = 1; i <=7; i++)
            {
                garages.Add(new Garage
                {
                    Id = i,
                    Name= $"Garage_{i}",
                    Type=GarageEnum.abcparking
                });
            }
            return garages;
        }
    }
}
