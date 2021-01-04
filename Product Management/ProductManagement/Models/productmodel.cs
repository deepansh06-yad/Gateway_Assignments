using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductManagement.Models
{
    public class productmodel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Product Name is required")]
        [Display(Name ="Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Image Path is required")]
        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
       public HttpPostedFileBase ImageFile { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        public string ShortDescription { get; set; }
        
        [Display(Name = "Details")]
        public string Detaildescription { get; set; }
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public int Category { get; set; }

        public virtual Categorymodel Category1 { get; set; }
    
    }
}