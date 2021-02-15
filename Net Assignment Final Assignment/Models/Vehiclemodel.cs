using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vehiclemodel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiclemodel()
        {
            this.Services = new HashSet<Servicemodel>();
        }

        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public string ChassisNo { get; set; }
        public string OwnerName { get; set; }
        public int OwnerId { get; set; }

        public virtual Customermodel Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicemodel> Services { get; set; }
    }
}
