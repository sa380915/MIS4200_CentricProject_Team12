using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class recognitonDetails
    {
        [Key]
        public int recognitionDetailsId { get; set; }
        public ICollection<Recognition> Recognitions { get; set; }
        public ICollection<User> Users { get; set; }
    }
}