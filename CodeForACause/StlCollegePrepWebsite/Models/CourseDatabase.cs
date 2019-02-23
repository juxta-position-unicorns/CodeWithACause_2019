using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StlCollegePrepWebsite.Models
{
    public class CourseDatabase : DbContext
    {
        public CourseDatabase()
        {
            Database.SetInitializer<CourseDatabase>(null);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}