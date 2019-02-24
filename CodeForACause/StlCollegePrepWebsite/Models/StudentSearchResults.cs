using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class StudentSearchResults
    {
        public string Search { get; set; }
        public IPagedList<Student> Results { get; set; }
    }
}