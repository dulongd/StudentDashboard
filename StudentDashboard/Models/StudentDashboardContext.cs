﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentDashboard.Models
{
    public class StudentDashboardContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public StudentDashboardContext() : base ("name=StudentDashboardConnection")
        {
            
        }
    }
}