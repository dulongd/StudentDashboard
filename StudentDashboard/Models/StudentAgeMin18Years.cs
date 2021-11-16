using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDashboard.Models
{
    public class StudentAgeMin18Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student) validationContext.ObjectInstance;
            var birthdate = student.Birthdate;

            var age = (DateTime.Today.Year - birthdate.Year);

            if (age == 18)
            {
                if ((DateTime.Today.Month < birthdate.Month) 
                    || (DateTime.Today.Month == birthdate.Month
                        && DateTime.Today.Day < birthdate.Day))
                {
                    age--;
                }
            }

            return (age >=18) ? ValidationResult.Success 
                : new ValidationResult("Student must be at least 18 years old.");


        }
    }
}