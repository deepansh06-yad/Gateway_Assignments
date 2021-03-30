using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.HRM.Database
{
    public partial class Departments
    {
        public Departments()
        {
            this.Employees = new HashSet<Employees>();
        }
        [Key]
        public int Id { get; set; }
        public string Department { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
