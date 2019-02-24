using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    [Table("Student")]
    public class Student : IEquatable<Student>
    {
        [Key]
        [MaxLength(128)]
        [Display(Name ="User Id")]
        public string UserId { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }       

        [Required]
        [MaxLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        public bool? IEP { get; set; }

        [Display(Name = "Graduate By")]
        [MaxLength(20)]
        public string GraduateBy { get; set; }
        
        public bool Equals(Student other)
        {
            if (other == null) { return false; }
            if (object.ReferenceEquals(this, other)) { return true; }

            return this.StudentNumber == other.StudentNumber &&
                   this.LastName == other.LastName &&
                   this.FirstName == other.FirstName;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Course);
        }

        public override int GetHashCode() => (StudentNumber, LastName, FirstName).GetHashCode();
    }
}