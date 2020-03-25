using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class recognitionDetails
    {
        //public System.Guid RDID { get; set; }
        public int recognitionDetailsId { get; set; }
        [Display(Name = "Employee")]
        [Required]
        public int employeeId { get; set; }
        public virtual Employee Employee { get; set; }
        [Display(Name = "Recognition Explanation")]
        [Required(ErrorMessage = "Recognition explanation required. Must be 200 characters or less.")]
        [StringLength(200)]
        public string explanation { get; set; }
        [Display(Name = "Recognition")]
        [Required]
        public int recognitionId { get; set; }
        public virtual Recognition Recognition { get; set; }

        //public ICollection<Recognition> Recognitions { get; set; }
        //public ICollection<Employee> Employees { get; set; }

    }
}