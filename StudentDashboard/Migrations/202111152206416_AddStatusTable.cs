namespace StudentDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Status_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "Status_Id");
            AddForeignKey("dbo.Students", "Status_Id", "dbo.Status", "Id", cascadeDelete: true);
            DropColumn("dbo.Students", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Status", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "Status_Id", "dbo.Status");
            DropIndex("dbo.Students", new[] { "Status_Id" });
            DropColumn("dbo.Students", "Status_Id");
            DropTable("dbo.Status");
        }
    }
}
