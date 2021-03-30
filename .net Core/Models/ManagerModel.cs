using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public partial class ManagerModel
    {
        public ManagerModel()
        {
            this.employess = new HashSet<EmployeeModel>();
        }
        [Key]
        public int Id { get; set; }
        public string Manager { get; set; }
        public virtual ICollection<EmployeeModel> employess { get; set; }
    }
}
