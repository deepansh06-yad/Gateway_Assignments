using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SourceControlAssignment1.Models
{
    public class employee
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Id")]
        public int id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "FirstName")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string lastname { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Age is Required")]
        [FormValidation.CustomAttribute.MinAge(18)]
        public int Age { get; set; }
        [Required(ErrorMessage = "Hire date is required")]
        [Display(Name = "Hire date")]
        public System.DateTime? hiredate { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Incorrect Email Format")]
        public string email { get; set; }
        [Required(ErrorMessage = "Confirm Email is required")]
        [Display(Name = "Confirm Email")]
        [System.ComponentModel.DataAnnotations.Compare("email", ErrorMessage = "Email is in valid")]
        public string confirmmail { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Display(Name = "phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number")]
        public int phone { get; set; }
    }
}