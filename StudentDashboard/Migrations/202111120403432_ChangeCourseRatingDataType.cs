namespace StudentDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCourseRatingDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseRating", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "CourseRating", c => c.Int(nullable: false));
        }
    }
}
