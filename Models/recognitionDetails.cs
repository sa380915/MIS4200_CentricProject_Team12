using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class recognitionDetails
    {
        [Key]
        public int recognitionDetailsId { get; set; }

        public int employeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string explanation { get; set; }
        public int recognitionId { get; set; }
        public virtual Recognition Recognition { get; set; }

        //public ICollection<Recognition> Recognitions { get; set; }
        //public ICollection<Employee> Employees { get; set; }

    }
}