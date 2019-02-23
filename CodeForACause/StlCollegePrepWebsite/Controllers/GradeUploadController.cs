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
        private CourseDatabase _db = new CourseDatabase();

        // GET: GradeUpload
        /*new List<Peirod> Perirod Model currently not in.*/
        public ActionResult Index()
        {

            new List<CourseStudent>();
            return View(new List<Student>());
        }

        
        [HttpPost]
        public ActionResult Index(int year, string semester, HttpPostedFileBase postedFile)
        {
            List<Student> students = new List<Student>();

            if (ValidateFile(postedFile))
            {
                string filePath = string.Empty;
                string path = Server.MapPath("~/Uploads/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);

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
                            CourseName = tokens[3],
                            PeriodName = tokens[4],
                            Semester = semester,
                            Year = year,
                        };
                        students.Add(student);

                        var courseStudent = new CourseStudent
                        {
                            //CourseId = courseId,
                            //StudentId = studentId,
                            Student = student,
                            Course = course,
                            AwardedGrade = Double.Parse(tokens[5]),
                        };

                        _db.Courses.Add(course);
                        _db.Students.Add(student);
                        _db.CourseStudents.Add(courseStudent);
                    
                    }
                    _db.SaveChanges();
                }
            }

            return View(students);
        }

        private bool ValidateFile(HttpPostedFileBase file)
        {
            string error;
            if (file == null)
            {
                error = "Please select a file";
                return false;
            }
            if (file.ContentLength <= 0)
            {
                error = "File size was zero";
                return false;
            }
            if (file.ContentLength >= 5242880)
            {
                error = "File size was to large.";
                return false;
            }

            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            if (".csv" != fileExtension)
            {
                error = $"File extension {fileExtension} is not valid for this form.";
                return false;
            }
            return true;
        }
    }
}