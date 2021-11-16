using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentDashboard.Models;

namespace StudentDashboard.ViewModels
{
    public class CourseDetailsViewModel
    {
        public Course Course { get; set; }
        public IEnumerable<Student> Students { get; set; }

    }
}