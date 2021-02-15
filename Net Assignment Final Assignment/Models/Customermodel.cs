using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customermodel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customermodel()
        {
            this.Vehicles = new HashSet<Vehiclemodel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Home { get; set; }
        public string Note { get; set; }
        public string Password { get; set; }
        public Nullable<long> Pincode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiclemodel> Vehicles { get; set; }
    }
}
