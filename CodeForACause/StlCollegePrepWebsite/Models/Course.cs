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
        
        public string InstructorId { get; set; }
        
        public string Subject { get; set; }
        public int? Level { get; set; }
        public double? CreditHours { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? Year { get; set; }
        public string Semester { get; set; }
        public string CourseName { get; set; }
        public string PeriodName { get; set; }
    }
}