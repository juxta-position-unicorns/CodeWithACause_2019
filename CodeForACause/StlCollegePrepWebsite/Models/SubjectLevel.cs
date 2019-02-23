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
        public string CourseName { get; set; }

        public string Subject { get; set; }

        public int Level { get; set; }

        public bool IsElective { get; set; }

        public float CreditHours { get; set; }
    }
}