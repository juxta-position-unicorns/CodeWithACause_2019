using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class GradeUploadViewModel
    {
        public GradeUploadViewModel()
        {
            Duplicates = new List<int>();
        }

        [Required]
        public int? Year { get; set; }
        [Required]
        public string Semester { get; set; }
        [Required]
        [Display(Name = "CSV File")]
        public HttpPostedFileBase PostedFile { get; set; }

        public List<int> Duplicates { get; set; }
    }
}