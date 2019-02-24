using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    [Table("SubjectLevel")]
    public class SubjectLevel
    {
        [Key]
        [Display(Name = "Course Name")]
        [MaxLength(100)]
        public string CourseName { get; set; }

        [Display(Name = "Subject")]
        [MaxLength(30)]
        public string Subject { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        public bool IsElective { get; set; }

        [Display(Name = "Credit Hours")]
        public double? CreditHours { get; set; }
    }
}