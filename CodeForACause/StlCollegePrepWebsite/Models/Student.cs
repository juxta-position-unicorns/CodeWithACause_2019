﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        public string StudentNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string SchoolName { get; set; }

        public bool? IEP { get; set; }

        [Display(Name = "Graduate By")]
        public string GraduateBy { get; set; }
    }
}