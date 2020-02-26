using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class Recognition
    {
        [Key]
        public int recongitionId { get; set; }
        public string description { get; set; }
        
        public ICollection<recognitonDetails> recognitonDetails { get; set; }
        



    }
}