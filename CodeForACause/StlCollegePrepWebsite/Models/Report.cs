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
        public string ReportName { get; set; }
        [Display(Name = "Report Description")]
        public string ReportDescription { get; set; }
        public int? Height { get; set; }
    }
}