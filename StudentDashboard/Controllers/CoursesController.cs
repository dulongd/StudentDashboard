using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentDashboard.Models;

namespace StudentDashboard.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            var courses = new List<Course>();
            return View(courses);
        }
    }
}