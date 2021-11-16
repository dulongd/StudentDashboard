using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using StudentDashboard.Models;
using StudentDashboard.ViewModels;

namespace StudentDashboard.Controllers
{
    public class StudentsController : Controller
    {

        private StudentDashboardContext _context;

        public StudentsController()
        {
            _context = new StudentDashboardContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Students
        public ActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public ActionResult New()
        {
            var courses = _context.Courses.ToList();
            var statuses = _context.Statuses.ToList();
            var viewModel = new StudentFormViewModel()
            {
                Courses = courses,
                Statuses = statuses
            };

            return View("StudentForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Student student)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new StudentFormViewModel(student)
                {
                    Courses = _context.Courses.ToList(),
                    Statuses = _context.Statuses.ToList()
                };
                return View("StudentForm", viewModel);
            }

            if (student.Id == 0)
            {
                _context.Students.Add(student);
            }
            else
            {
                var studentInDb = _context.Students.Single(s => s.Id == student.Id);

                studentInDb.FirstName = student.FirstName;
                studentInDb.LastName = student.LastName;
                studentInDb.CourseId = student.CourseId;
                studentInDb.EnrolledDate = student.EnrolledDate;
                studentInDb.StatusId = student.StatusId;
                studentInDb.Grade = student.Grade;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Students");
        }

        public ActionResult Edit(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);
            var courses = _context.Courses.ToList();
            var statuses = _context.Statuses.ToList(); 

            if (student == null)
            {
                return HttpNotFound();
            }

            var viewModel = new StudentFormViewModel(student)
            {
                Courses = courses,
                Statuses = statuses
            };

            return View("StudentForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);

            if (student == null)
            {
                return HttpNotFound();
            }

            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("Index", "Students");
        }


    }
}
