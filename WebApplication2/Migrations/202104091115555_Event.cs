namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Event : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainingApplications",
                c => new
                    {
                        ApplicationId = c.String(nullable: false, maxLength: 128),
                        EventName = c.String(nullable: false, unicode: false, storeType: "text"),
                        email = c.String(nullable: false, unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrainingApplications");
        }
    }
}
