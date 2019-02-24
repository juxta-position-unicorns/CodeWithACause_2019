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
        [MaxLength(128)]
        [Display(Name="User ID")]
        public string UserId { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}