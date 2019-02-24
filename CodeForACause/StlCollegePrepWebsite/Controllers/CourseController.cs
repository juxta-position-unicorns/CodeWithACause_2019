using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StlCollegePrepWebsite.Models;
using PagedList;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace StlCollegePrepWebsite.Controllers
{
    public class CourseController : Controller
    {
        private CourseDatabase db = new CourseDatabase();

        // GET: Course
        public ActionResult Index(
            string search,
            string semester,
            string subject,
            string period,
            string instructorId,
            string sortBy,
            int? page,
            int? itemsPerPage
            )
        {
            

            IQueryable<CourseInfo> courses =
            from c in db.Courses
            join i in db.Instructors on c.InstructorId equals i.UserId into ig
            select new CourseInfo
            {
                CourseId = c.CourseId,
                InstructorId = c.InstructorId,
                CourseName = c.CourseName,
                Subject = c.Subject,
                Level = c.Level,
                CreditHours = c.CreditHours,
                PeriodName = c.PeriodName,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                Year = c.Year,
                Semester = c.Semester,
                InstructorName = ig.FirstOrDefault().Name                
            };
            

            if (!string.IsNullOrWhiteSpace(semester))
            {
                string[] tokens = semester.Split(' ');
                int year = int.Parse(tokens[0]);
                courses = courses.Where(x => x.Year == year && x.Semester == tokens[1]);
            }
            if (!string.IsNullOrWhiteSpace(subject))
            {
                courses = courses.Where(x => x.Subject == subject);
            }
            if (!string.IsNullOrWhiteSpace(period))
            {
                courses = courses.Where(x => x.PeriodName == period);
            }
            if (!string.IsNullOrWhiteSpace(instructorId))
            {
                courses = courses.Where(x => x.InstructorId == instructorId);
            }
            if (!String.IsNullOrWhiteSpace(search))
            {
                courses = courses.Where(x => x.CourseName.Contains(search));
            }

            courses = courses.OrderBy(x => x.CourseName).ThenBy(x => x.CourseId);

            var results = courses.ToPagedList(page ?? 1, itemsPerPage ?? 25);

            var model = new CourseSearchResults
            {
                Search = search,
                Semester = semester,
                Subject = subject,
                Period = period,
                InstructorId = instructorId,
                SortBy = sortBy,
                Instructors = db.Instructors.OrderBy(x => x.UserId).ToList(),
                Periods = db.Periods.OrderBy(x => x.PeriodName).ToList(),
                Results = results,
            };

            return View("Index", model);
        }

        // GET: Course/Details/5
        public ActionResult Details(int? id)
        {
            IQueryable<StudentInfo> studentCourseList =
                from cs in db.CourseStudents
                join s in db.Students on cs.StudentId equals s.UserId
                where cs.CourseId == id
                orderby s.LastName, s.FirstName, s.StudentNumber
                select new StudentInfo
                {
                    StudentNumber = s.StudentNumber,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    AwardedGrade = cs.AwardedGrade
                };
                        
            ViewBag.StudentCourseList = studentCourseList;            

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseId,InstructorId,Subject,Level,CreditHours,StartTime,EndTime,Year,Semester")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseId,InstructorId,Subject,Level,CreditHours,StartTime,EndTime,Year,Semester")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
