using System;
using System.Collections.Generic;
using System.Linq;
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
            var viewModel = new StudentFormViewModel()
            {
                Courses = courses
            };

            return View("StudentForm", viewModel);
        }

        public ActionResult Save()
        {
            return RedirectToAction("Index", "Students");
        }


    }
}
