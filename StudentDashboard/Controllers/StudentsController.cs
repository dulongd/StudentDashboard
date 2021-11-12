using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentDashboard.Models;

namespace StudentDashboard.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            /*
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Danielle",
                    EnrolledDate = new DateTime(),
                    CourseId = 1,
                    Grade = "A",
                    Status = 0
                }
            };
            */

            return View(students);
        }
    }
}
