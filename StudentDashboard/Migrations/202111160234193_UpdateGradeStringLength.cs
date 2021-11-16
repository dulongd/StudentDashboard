namespace StudentDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGradeStringLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false, maxLength: 1));
        }
    }
}
