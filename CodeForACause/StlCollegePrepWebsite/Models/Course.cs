using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StlCollegePrepWebsite.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        
        public int InstructorId { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public int Level { get; set; }
        public float? CreditHours { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Year { get; set; }
        public string Semester { get; set; }
    }
}