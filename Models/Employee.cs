using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_CentricProject_Team12.Models
{
    public class Employee
    {
        
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime employeeSince { get; set; }
        public ICollection<recognitionDetails> recognitionDetails { get; set; }


    }
}