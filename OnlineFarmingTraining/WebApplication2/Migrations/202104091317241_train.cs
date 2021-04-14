namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class train : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TrainingApplications", name: "EventName", newName: "Event Name");
            RenameColumn(table: "dbo.TrainingApplications", name: "email", newName: "Email:");
            DropPrimaryKey("dbo.TrainingApplications");
            AddColumn("dbo.FarmersTraining", "TrainingTime", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            AddColumn("dbo.TrainingApplications", "FirstName", c => c.String());
            AddColumn("dbo.TrainingApplications", "Last Name:", c => c.String());
            AlterColumn("dbo.FarmersTraining", "Description", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.TrainingApplications", "ApplicationId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TrainingApplications", "Event Name", c => c.String(nullable: false));
            AlterColumn("dbo.TrainingApplications", "Email:", c => c.String(nullable: false));
            AddPrimaryKey("dbo.TrainingApplications", "ApplicationId");
            DropColumn("dbo.FarmersTraining", "TrainingCentre");
            DropColumn("dbo.FarmersTraining", "TrainingTme");
            DropTable("dbo.Imagings");
            DropTable("dbo.Students");
            DropTable("dbo.tblTrainers");
            DropTable("dbo.tblTrainingCentre");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblTrainingCentre",
                c => new
                    {
                        TrainingcentreId = c.Int(nullable: false, identity: true),
                        TrainingCentre = c.String(nullable: false, maxLength: 200, unicode: false),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedOn = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.TrainingcentreId);
            
            CreateTable(
                "dbo.tblTrainers",
                c => new
                    {
                        TrainerId = c.Int(nullable: false, identity: true),
                        TrainerName = c.String(nullable: false, maxLength: 100, unicode: false),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedOn = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.TrainerId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Imagings",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        Image = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.ImageId);
            
            AddColumn("dbo.FarmersTraining", "TrainingTme", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            AddColumn("dbo.FarmersTraining", "TrainingCentre", c => c.String(nullable: false, maxLength: 200, unicode: false));
            DropPrimaryKey("dbo.TrainingApplications");
            AlterColumn("dbo.TrainingApplications", "Email:", c => c.String(nullable: false, unicode: false, storeType: "text"));
            AlterColumn("dbo.TrainingApplications", "Event Name", c => c.String(nullable: false, unicode: false, storeType: "text"));
            AlterColumn("dbo.TrainingApplications", "ApplicationId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.FarmersTraining", "Description", c => c.String(nullable: false, maxLength: 500, unicode: false));
            DropColumn("dbo.TrainingApplications", "Last Name:");
            DropColumn("dbo.TrainingApplications", "FirstName");
            DropColumn("dbo.FarmersTraining", "TrainingTime");
            AddPrimaryKey("dbo.TrainingApplications", "ApplicationId");
            RenameColumn(table: "dbo.TrainingApplications", name: "Email:", newName: "email");
            RenameColumn(table: "dbo.TrainingApplications", name: "Event Name", newName: "EventName");
        }
    }
}
