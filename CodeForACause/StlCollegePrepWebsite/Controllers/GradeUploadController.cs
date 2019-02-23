using StlCollegePrepWebsite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StlCollegePrepWebsite.Controllers
{
    public class GradeUploadController : Controller
    {
        // GET: GradeUpload
        /*new List<Peirod> Perirod Model currently not in.*/
        public ActionResult Index()
        {
            new List<CourseStudent>();
            return View(new List<Student>());
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            List<Student> students = new List<Student>();
            List<CourseStudent> courseStudents = new List<CourseStudent>();
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);

                //var periods = db.Periods.ToList();

                //Read the contents of CSV file.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string currentLine;
                    // currentLine will be null when the StreamReader reaches the end of file
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        string[] tokens = currentLine.Split(',');
                        var student = new Student
                        {
                            //UserId = studentId,

                            LastName = tokens[0],
                            FirstName = tokens[1],
                            StudentNumber = tokens[2],
                        };
                        var course = new Course
                        {
                            CourseName = tokens[4],
                            PeriodName = tokens[5],
                            Semester = "", //pull in from View
                            Year = 0, //pull in from View
                        }; 
                        students.Add(student);

                        courseStudents.Add(new CourseStudent
                        {
                            //CourseId = courseId,
                            //StudentId = studentId,
                            Student = student,
                            Course = course,
                            AwardedGrade = Convert.ToDouble(tokens[5]),
                        });
                    }
                }
            }
            return View(students);
        }

    }
}