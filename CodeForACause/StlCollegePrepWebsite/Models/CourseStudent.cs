using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StlCollegePrepWebsite.Models
{
    [Table("CourseStudent")]
    public class CourseStudent
    {
        [Key, Column(Order = 0)]
        public int CourseId { get; set; }

        [Key, Column(Order = 1)]
        public string StudentId { get; set; }

        public int? AcademicYear { get; set; }
        public double? AwardedGrade { get; set; }

        // Navigation properties
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}