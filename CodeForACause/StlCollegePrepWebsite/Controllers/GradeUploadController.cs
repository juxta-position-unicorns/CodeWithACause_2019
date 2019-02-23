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

                //Read the contents of CSV file.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string currentLine;
                    // currentLine will be null when the StreamReader reaches the end of file
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        students.Add(new Student
                        {
                            //UserId = studentId,

                            LastName = currentLine.Split(',')[0],
                            FirstName = currentLine.Split(',')[1],
                            StudentNumber = currentLine.Split(',')[2],
                        });

                        courseStudents.Add(new CourseStudent
                        {
                            //CourseId = courseId,
                            //StudentId = studentId,

                            AwardedGrade = Convert.ToDouble(currentLine.Split(',')[5]),
                        });
                    }
                }
            }

            return View(students);
        }

    }
}