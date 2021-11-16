using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StudentAgeMin18Years]

        public DateTime Birthdate { get; set; }

        public Course Course { get; set; }

        public int CourseId { get; set; }

        [Required]
        public DateTime EnrolledDate { get; set; }

        public Status Status { get; set; }

        public int StatusId { get; set; }

        [Required]
        [StringLength(10)]
        public string Grade { get; set; }
    }
}