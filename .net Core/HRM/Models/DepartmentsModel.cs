using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class DepartmentsModel
    {
        public DepartmentsModel()
        {
            this.Employees = new HashSet<EmployeesModel>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Department { get; set; }
        public virtual ICollection<EmployeesModel> Employees { get; set; }
    }
}
