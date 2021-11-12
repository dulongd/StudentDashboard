using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using StudentDashboard.Models;

namespace StudentDashboard.ViewModels
{
    public class StudentFormViewModel
    {
        public IEnumerable<Course> Courses { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        public int? CourseId { get; set; }

        [Required]
        public DateTime? EnrolledDate { get; set; }

        [Required]
        public int? Status { get; set; }

        [Required]
        [StringLength(10)]
        public string Grade { get; set; }

        public string Title
        {
            get { return (Id != 0) ? "Edit Student" : "Add New Student"; }
        }

        public bool IsNewStudent
        {
            get
            {
                return (Id == 0);
            }
        }

        public static readonly int inProgress = 0;
        public static readonly int Completed = 1;

        public StudentFormViewModel()
        {
            Id = 0;
            EnrolledDate = DateTime.Now;
        }

        public StudentFormViewModel(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            CourseId = student.CourseId;
            EnrolledDate = student.EnrolledDate;
            Status = student.Status;

        }
    }
}