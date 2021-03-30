using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public partial class DepartmentModel
    {
        public DepartmentModel()
        {
            this.Employees = new HashSet<EmployeeModel>();
        }
        [Key]
        public int Id { get; set; }
        public string Department { get; set; }
        public virtual ICollection<EmployeeModel> Employees { get; set; }
    }
}
