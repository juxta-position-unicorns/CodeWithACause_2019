using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class StudentDetails
    {
        public int? Year { get; set; }

        public string Semester { get; set; }

        public string CourseName { get; set; }

        public string Subject { get; set; }

        [Display(Name = "Final Grade")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public decimal? AwardedGrade { get; set; }

        //public int? AcademicYear { get; set; }

        public double? CreditHours { get; set; }
    }
}