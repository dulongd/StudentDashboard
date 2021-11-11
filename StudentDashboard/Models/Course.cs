using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDashboard.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string CourseName { get; set; }

        [Required]
        public string CourseDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string TutorName { get; set; }

        [Required]
        [Range(1,10)]
        public int CourseRating { get; set; }
    }
}