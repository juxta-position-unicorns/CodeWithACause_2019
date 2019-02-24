using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class StudentInfo
    {
        public string StudentNumber { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public decimal? AwardedGrade { get; set; }
    }
}