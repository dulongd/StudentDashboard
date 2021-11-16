using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentDashboard.Models;
using System.Data.Entity;
using System.Web.Configuration;
using StudentDashboard.ViewModels;

namespace StudentDashboard.Controllers
{
    public class CoursesController : Controller
    {
        private StudentDashboardContext _context;

        public CoursesController()
        {
            _context = new StudentDashboardContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Courses
        public ActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        public ActionResult New()
        {
            var viewModel = new CourseFormViewModel();
            return View("CourseForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Course course)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CourseFormViewModel(course);
                return View("CourseForm", viewModel);
            }

            if (course.Id == 0)
            {
                _context.Courses.Add(course);
            }
            else
            {
                var courseInDb = _context.Courses.Single(c => c.Id == course.Id);

                courseInDb.CourseName = course.CourseName;
                courseInDb.CourseDescription = course.CourseDescription;
                courseInDb.TutorName = course.TutorName;
                courseInDb.CourseRating = course.CourseRating;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Courses");
        }

        public ActionResult Edit(int id)
        {
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);
            
            if (course == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CourseFormViewModel(course);

            return View("CourseForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);

            if (course == null)
            {
                return HttpNotFound();
            }

            _context.Courses.Remove(course);
            _context.SaveChanges();

            return RedirectToAction("Index", "Courses");
        }

        public ActionResult Details(int id)
        {
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);
            var students = _context.Students.ToList();

            if (course == null)
            {
                return HttpNotFound();
            }

            var enrolledStudents = students.Where(student => student.CourseId == id);

            var viewModel = new CourseDetailsViewModel()
            {
                Course = course,
                Students = enrolledStudents
            };

            return View(viewModel);
        }
    }
}