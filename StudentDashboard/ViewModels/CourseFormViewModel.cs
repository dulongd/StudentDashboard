using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using StudentDashboard.Models;

namespace StudentDashboard.ViewModels
{
    public class CourseFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Tutor Name")]
        public string TutorName { get; set; }

        [Required]
        [Range(1, 10)]
        [Display(Name = "Course Rating")]
        public byte? CourseRating { get; set; }

        public string Title
        {
            get
            {
                return (Id != 0) ? "Edit Course" : "Add New Course";
            }
        }

        public bool IsNewCustomer
        {
            get
            {
                return (Id == 0); 
            }
        }

        public CourseFormViewModel()
        {
            Id = 0;
        }

        public CourseFormViewModel(Course course)
        {
            Id = course.Id;
            CourseName = course.CourseName;
            CourseDescription = course.CourseDescription;
            TutorName = course.TutorName;
            CourseRating = course.CourseRating;
        }


    }
}