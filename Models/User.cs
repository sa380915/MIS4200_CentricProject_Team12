using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class User
    {
        [Key]
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime employeeSince { get; set; }
        public ICollection<recognitonDetails> recognitonDetails { get; set; }





    }
}