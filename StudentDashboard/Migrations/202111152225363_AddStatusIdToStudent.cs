namespace StudentDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusIdToStudent : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Status_Id", newName: "StatusId");
            RenameIndex(table: "dbo.Students", name: "IX_Status_Id", newName: "IX_StatusId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Students", name: "IX_StatusId", newName: "IX_Status_Id");
            RenameColumn(table: "dbo.Students", name: "StatusId", newName: "Status_Id");
        }
    }
}
