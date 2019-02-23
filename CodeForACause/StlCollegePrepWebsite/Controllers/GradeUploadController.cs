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
                string csvData = System.IO.File.ReadAllText(filePath);

                //Execute a loop over the rows.
                foreach (string row in csvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        students.Add(new Student
                        {
                            //UserId = studentId,

                            LastName = row.Split(',')[0],
                            FirstName = row.Split(',')[1],
                            StudentNumber = row.Split(',')[2],
                        });

                        courseStudents.Add(new CourseStudent
                        {
                            //CourseId = courseId,
                            //StudentId = studentId,

                            AwardedGrade = Convert.ToDouble(row.Split(',')[5]),
                        });
                    }
                }
            }

            return View(students);
        }

    }
}