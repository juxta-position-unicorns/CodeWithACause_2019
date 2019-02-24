using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class StudentInfo
    {
        public string StudentNumber { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [Display(Name = "Final Grade")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public decimal? AwardedGrade { get; set; }
    }
}