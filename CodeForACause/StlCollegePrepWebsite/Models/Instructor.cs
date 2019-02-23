using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    [Table("Instructor")]
    public class Instructor
    {
        [Key]
        public string UserId { get; set; }
        public string Name { get; set; }
    }
}