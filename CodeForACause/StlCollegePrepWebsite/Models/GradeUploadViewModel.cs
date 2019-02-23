using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class GradeUploadViewModel
    {
        [Required]
        public int? Year { get; set; }
        [Required]
        public string Semester { get; set; }
        [Required]
        public HttpPostedFileBase PostedFile { get; set; }
    }
}