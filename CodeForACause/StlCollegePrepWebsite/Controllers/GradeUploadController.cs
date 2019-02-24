using StlCollegePrepWebsite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StlCollegePrepWebsite.Controllers
{
    public class GradeUploadController : Controller
    {
        private CourseDatabase _db = new CourseDatabase();

        private class StudentGrade
        {
            public int RowNumber { get; set; }
            public string RecordId { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string StudentNumber { get; set; }
            public string CourseName { get; set; }
            public string PeriodName { get; set; }
            public decimal FinalGrade { get; set; }
        }
        
        public ActionResult Index()
        {
            return View(new GradeUploadViewModel());
        }
        
        [HttpPost]
        public async Task<ActionResult> Index(GradeUploadViewModel viewModel)
        {
            try
            {
                var postedFile = viewModel.PostedFile;
                if (ModelState.IsValid && ValidateFile("PostedFile", postedFile))
                {
                    string folderPath = Server.MapPath("~/Uploads/");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string filePath = folderPath + Path.GetFileName(postedFile.FileName);
                    postedFile.SaveAs(filePath);

                    var grades = new List<StudentGrade>();
                    var students = new List<Student>();
                    var courses = new List<Course>();

                    var courseNames = _db.SubjectLevels.ToList();
                    var periods = _db.Periods.ToList();

                    //Read the contents of CSV file.
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string currentLine = await sr.ReadLineAsync();
                        int rowNumber = 1;
                        if (currentLine != "Student Last Name,Student First Name,Student Number,Class Description,Grading Period Description,Final Grade")
                        {
                            throw new Exception("CSV column headers are not as expected");
                        }

                        // currentLine will be null when the StreamReader reaches the end of file
                        for (;;)
                        {
                            currentLine = await sr.ReadLineAsync();
                            ++rowNumber;
                            if (currentLine == null) { break; }

                            string[] tokens = currentLine.Split(',');
                            var grade = new StudentGrade
                            {
                                RowNumber = rowNumber,
                                RecordId = Guid.NewGuid().ToString(),
                                LastName = tokens[0].Trim(),
                                FirstName = tokens[1].Trim(),
                                StudentNumber = tokens[2].Trim(),
                                CourseName = tokens[3].Trim(),
                                PeriodName = tokens[4].Trim(),
                                FinalGrade = ParseGrade(tokens[5]),
                            };
                            grades.Add(grade);
                            
                            var student = new Student
                            {
                                UserId = grade.RecordId,

                                LastName = grade.LastName,
                                FirstName = grade.FirstName,
                                StudentNumber = grade.StudentNumber,
                            };
                            students.Add(student);

                            var course = new Course
                            {
                                CourseName = grade.CourseName,
                                PeriodName = grade.PeriodName,
                                Semester = viewModel.Semester,
                                Year = viewModel.Year,
                                CreditHours = 0.5f,
                            };
                            courses.Add(course);

                            var courseName = courseNames.FirstOrDefault(
                                x => x.CourseName == grade.CourseName || 
                                     x.CourseName == grade.CourseName.Substring(0, grade.CourseName.Length - 2));
                            if (courseName != null)
                            {
                                course.Subject = courseName.Subject;
                                course.Level = courseName.Level;
                                //course.CreditHours = courseName.CreditHours;
                            }

                            var period = periods.FirstOrDefault(x => x.PeriodName == grade.PeriodName);
                            if (period != null)
                            {
                                course.StartTime = period.StartTime;
                                course.EndTime = period.EndTime;
                            }
                        }

                        viewModel.Duplicates =
                            grades.GroupBy(x => new { x.StudentNumber, x.FirstName, x.LastName, x.CourseName, x.PeriodName })
                                  .Where(g => g.Count() > 1)
                                  .SelectMany(g => g.Select(x => x.RowNumber))
                                  .OrderBy(x => x)
                                  .ToList();
                        if (viewModel.Duplicates.Any())
                        {
                            throw new Exception("Duplicate grades in CSV file");
                        }

                        students = students.GroupBy(x => new { x.StudentNumber, x.FirstName, x.LastName }).Select(g => g.FirstOrDefault()).ToList();
                        courses = courses.GroupBy(x => new { x.CourseName, x.PeriodName }).Select(g => g.FirstOrDefault()).ToList();

                        if (viewModel.DeleteGradesForSemester)
                        {
                            var existingGrades = (
                                from cs in _db.CourseStudents
                                join c in _db.Courses on cs.CourseId equals c.CourseId
                                where c.Year == viewModel.Year && c.Semester == viewModel.Semester
                                select cs
                            ).ToList();
                            _db.CourseStudents.RemoveRange(existingGrades);
                        }

                        var existingStudents = _db.Students.ToList();
                        var existingCourses = _db.Courses.Where(x => x.Year == viewModel.Year && x.Semester == viewModel.Semester).ToList();
                        var newStudents = students.Except(existingStudents).ToList();
                        var newCourses = courses.Except(existingCourses).ToList();
                        var allStudents = existingStudents.Union(newStudents);
                        var allCourses = existingCourses.Union(newCourses);

                        foreach (var grade in grades)
                        {
                            var courseStudent = new CourseStudent
                            {
                                Student = allStudents.First(x => x.StudentNumber == grade.StudentNumber && x.FirstName == grade.FirstName && x.LastName == grade.LastName),
                                Course = allCourses.First(x => x.CourseName == grade.CourseName && x.PeriodName == grade.PeriodName),
                                AwardedGrade = grade.FinalGrade,
                            };
                            _db.CourseStudents.Add(courseStudent);
                        }

                        _db.Students.AddRange(newStudents);
                        _db.Courses.AddRange(newCourses);
                        _db.SaveChanges();
                        return RedirectToAction("Index", "Report");
                    }
                }
            }
            catch (Exception ex)
            {
                while (ex.Message == "An error occurred while updating the entries. See the inner exception for details.")
                {
                    ex = ex.InnerException;
                }
                ModelState.AddModelError("PostedFile", ex.Message);
            }

            return View(viewModel);
        }
        
        private bool ValidateFile(string key, HttpPostedFileBase file)
        {
            if (file == null)
            {
                ModelState.AddModelError(key, "Please select a file");
                return false;
            }
            if (file.ContentLength <= 0)
            {
                ModelState.AddModelError(key, "File size was zero");
                return false;
            }
            if (file.ContentLength >= 5242880) // What limit??
            {
                ModelState.AddModelError(key, "File size was to large.");
                return false;
            }

            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            if (".csv" != fileExtension)
            {
                ModelState.AddModelError(key, $"File extension must be .csv, file extension was {fileExtension}");
                return false;
            }
            return true;
        }

        private decimal ParseGrade(string grade)
        {
            // TODO: handle letter grades
            return decimal.Parse(grade);
        }
    }
}