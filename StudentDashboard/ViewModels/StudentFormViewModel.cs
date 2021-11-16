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
        public IEnumerable<Status> Statuses { get; set; }

        public int? Id { get; set; }

        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Course")]
        public int? CourseId { get; set; }

        [Required]
        [Display(Name = "Enrolled Date")]
        public DateTime? EnrolledDate { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int? StatusId { get; set; }

        [Required]
        [StringLength(10)]
        public string Grade { get; set; }

        public bool IsNewStudent
        {
            get
            {
                return (Id == 0);
            }
        }

        public string Title
        {
            get
            {
                return (IsNewStudent) ? "Add New Student" : "Edit Student";
            }
        }

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
            StatusId = student.StatusId;
            Grade = student.Grade;
        }
    }
}