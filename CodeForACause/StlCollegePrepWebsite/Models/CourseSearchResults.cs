using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class CourseSearchResults
    {
        [Display(Name = "Search")]
        public string Search { get; set; }

        [Display(Name = "Semester")]
        public string Semester { get; set; }

        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Display(Name = "Period")]
        public string Period { get; set; }

        [Display(Name = "Instructor Id")]
        public string InstructorId { get; set; }

        [Display(Name = "Sort By")]
        public string SortBy { get; set; }

        //public IEnumerable

        public IPagedList<Course> Results { get; set; }

    }
}