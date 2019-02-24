using System;
using PagedList;
namespace StlCollegePrepWebsite.Models
{
    public class StudentSearchResuts
    {
        public string Search { get; set; }
        public IPagedList<Student> Results { get; set; }
    }
}
