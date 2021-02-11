using GarageEntities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageEntities.Entities
{
    public class Garage
    {
        public Garage()
        { }

        public long Id { get; set; }
        public string Name { get; set; }
        public GarageEnum Type { get; set; }
        public string TypeName => Type.ToString();
    }
}
