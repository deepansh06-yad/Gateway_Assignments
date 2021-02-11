using System;
using System.Collections.Generic;
using System.Text;

namespace GarageEntities.Entities
{
    public class GarageName
    {
        public GarageName()
        { }
        public long Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public int StaffMembers { get; set; }
    }
}
