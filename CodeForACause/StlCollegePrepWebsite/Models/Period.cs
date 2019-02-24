using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    [Table("Period")]
    public class Period
    {
        [Key] 
        [MaxLength(20)]
        [Display(Name = "Period Name")]
        public string PeriodName { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }

    }
}