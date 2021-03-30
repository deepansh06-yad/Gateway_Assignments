using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.HRM.Database
{
    public partial class Managers
    {
        public Managers()
        {
            this.employess = new HashSet<Employees>();
        }
        [Key]
        public int Id { get; set;}
        public string Manager { get; set; }
        public virtual ICollection<Employees> employess { get; set; }
    }
}
