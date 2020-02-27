using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class recognitionDetails
    {

        public int recognitionDetailsId { get; set; }
        public string recognitionTitle { get; set; }
        public string explanation { get; set; }

        public ICollection<Recognition> Recognitions { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}