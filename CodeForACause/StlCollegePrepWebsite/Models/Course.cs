using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StlCollegePrepWebsite.Models
{
    [Table("Course")]
    public class Course : IEquatable<Course>
    {
        [Key]
        public int CourseId { get; set; }
        
        [MaxLength(128)]
        [Display(Name = "Instructor")]
        public string InstructorId { get; set; }

        [MaxLength(100)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [MaxLength(30)]
        public string Subject { get; set; }

        public int? Level { get; set; }
        
        [Display(Name = "Credit Hours")]
        public double? CreditHours { get; set; }

        [MaxLength(20)]
        [Display(Name = "Period")]
        public string PeriodName { get; set; }

        [Display(Name = "Start Time")]
        public TimeSpan? StartTime { get; set; }

        [Display(Name = "End Time")]
        public TimeSpan? EndTime { get; set; }

        public int? Year { get; set; }

        [MaxLength(20)]
        public string Semester { get; set; }

        public bool Equals(Course other)
        {
            if (other == null) { return false; }
            if (object.ReferenceEquals(this, other)) { return true; }
            
            return this.CourseName == other.CourseName &&
                   this.PeriodName == other.PeriodName;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Course);
        }

        public override int GetHashCode() => (CourseName, PeriodName).GetHashCode();
    }
}