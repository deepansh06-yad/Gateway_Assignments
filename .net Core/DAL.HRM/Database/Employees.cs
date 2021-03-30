using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.HRM.Database
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int Salary { get; set; }
        public bool IsManager { get; set; }
        public int ManagerId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual Managers Managers { get; set; }
    }
}
