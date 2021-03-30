using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class EmployeesModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public int Salary { get; set; }
        public bool IsManager { get; set; }
        [Required]
        public int ManagerId { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public virtual DepartmentsModel Departments { get; set; }
        public virtual ManagersModel Managers { get; set; }
    }
}
