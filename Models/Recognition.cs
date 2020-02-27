using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class Recognition
    {

        public int recognitionId { get; set; }
        public string recognitionTitle { get; set; }
        public string description { get; set; }
        public ICollection<recognitionDetails> recognitionDetails { get; set; }

    }
}