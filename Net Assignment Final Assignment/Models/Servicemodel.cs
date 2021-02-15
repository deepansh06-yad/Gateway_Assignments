using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Servicemodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Duration { get; set; }
        public bool Active { get; set; }
        public int Description { get; set; }

        public virtual Vehiclemodel Vehicle1 { get; set; }
    }
}
