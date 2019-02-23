using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StlCollegePrepWebsite.Models
{
    [Table("Report")]
    public class Report
    {
        [Key]
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public int? Height { get; set; }
    }
}