namespace StudentDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUnenrolledCourse : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (CourseName, CourseDescription, TutorName, CourseRating) VALUES" +
                "('Not Enrolled', 'N/A', 'N/A', 0)");
        }
        
        public override void Down()
        {
        }
    }
}
