using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StlCollegePrepWebsite.Models
{
    [Table("Report")]
    public class Report
    {
        [Key]
        [Display(Name = "Report Name")]
        [MaxLength(30)]
        public string ReportName { get; set; }

        [Display(Name = "Report Description")]
        public string ReportDescription { get; set; }

        [Display(Name = "Height")]
        public int? Height { get; set; }
    }
}