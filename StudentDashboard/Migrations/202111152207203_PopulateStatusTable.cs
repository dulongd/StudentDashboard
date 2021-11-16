namespace StudentDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatusTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Description) VALUES ('Unknown')");
            Sql("INSERT INTO Status (Description) VALUES ('In Progress')");
            Sql("INSERT INTO Status (Description) VALUES ('Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
