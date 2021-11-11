using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDashboard.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public DateTime EnrolledDate { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        [StringLength(10)]

        public string Grade { get; set; }

        public static readonly int inProgress = 0;
        public static readonly int Completed = 1;
    }
}