using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class ManagersModel
    {
        public ManagersModel()
        {
            this.employess = new HashSet<EmployeesModel>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Manager { get; set; }
        public virtual ICollection<EmployeesModel> employess { get; set; }
    }
}
