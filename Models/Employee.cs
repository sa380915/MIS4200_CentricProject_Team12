using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace MIS4200_CentricProject_Team12.Models
{
    public class Employee
    {
      

        //public System.Guid EID { get; set; }
        public Guid employeeId { get; set; }
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Employee first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
       
        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        
        [Display(Name = "Date you joined the company")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> employeeSince { get; set; }

        public ICollection<recognitionDetails> recognitionDetails { get; set; }
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }


    }
}