namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.FarmersTraining",
            //    c => new
            //        {
            //            TrainingId = c.Int(nullable: false, identity: true),
            //            TrainerName = c.String(nullable: false, maxLength: 200, unicode: false),
            //            TrainingCentre = c.String(nullable: false, maxLength: 200, unicode: false),
            //            EventName = c.String(nullable: false, maxLength: 100, unicode: false),
            //            Description = c.String(nullable: false, maxLength: 500, unicode: false),
            //            TrainingTme = c.DateTime(nullable: false, storeType: "smalldatetime"),
            //        })
            //    .PrimaryKey(t => t.TrainingId);
            
            //CreateTable(
            //    "dbo.Login",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserName = c.String(nullable: false, maxLength: 100, unicode: false),
            //            Password = c.String(nullable: false, maxLength: 100, unicode: false),
            //            CreatedBy = c.String(maxLength: 50, unicode: false),
            //            CreatedOn = c.DateTime(storeType: "smalldatetime"),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            //CreateTable(
            //    "dbo.tblTrainers",
            //    c => new
            //        {
            //            TrainerId = c.Int(nullable: false, identity: true),
            //            TrainerName = c.String(nullable: false, maxLength: 100, unicode: false),
            //            CreatedBy = c.String(maxLength: 100, unicode: false),
            //            CreatedOn = c.DateTime(storeType: "smalldatetime"),
            //        })
            //    .PrimaryKey(t => t.TrainerId);
            
            //CreateTable(
            //    "dbo.tblTrainingCentre",
            //    c => new
            //        {
            //            TrainingcentreId = c.Int(nullable: false, identity: true),
            //            TrainingCentre = c.String(nullable: false, maxLength: 200, unicode: false),
            //            CreatedBy = c.String(maxLength: 100, unicode: false),
            //            CreatedOn = c.DateTime(storeType: "smalldatetime"),
            //        })
            //    .PrimaryKey(t => t.TrainingcentreId);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.tblTrainingCentre");
            //DropTable("dbo.tblTrainers");
            DropTable("dbo.Students");
            //DropTable("dbo.Login");
            //DropTable("dbo.FarmersTraining");
        }
    }
}
