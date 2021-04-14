namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applicationtraining : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TrainingApplications", name: "Event Name", newName: "EventName");
            RenameColumn(table: "dbo.TrainingApplications", name: "Last Name:", newName: "LastName");
            RenameColumn(table: "dbo.TrainingApplications", name: "Email:", newName: "email");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.TrainingApplications", name: "email", newName: "Email:");
            RenameColumn(table: "dbo.TrainingApplications", name: "LastName", newName: "Last Name:");
            RenameColumn(table: "dbo.TrainingApplications", name: "EventName", newName: "Event Name");
        }
    }
}
