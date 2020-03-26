using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class Recognition
    {

        //public System.Guid RID { get; set; }
        public int recognitionId { get; set; }
        [Display(Name = "Recognition Title")]
        public string recognitionTitle { get; set; }
        [Display(Name = "Recognition Description")]
        public string description { get; set; }
        //[Display(Name = "Point Value")]
        //public int recognitionPoints { get; set; }

        public ICollection<recognitionDetails> recognitionDetails { get; set; }

    }
}