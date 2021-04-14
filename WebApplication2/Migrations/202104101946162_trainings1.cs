namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trainings1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrainingApplications", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.TrainingApplications", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrainingApplications", "LastName", c => c.String());
            AlterColumn("dbo.TrainingApplications", "FirstName", c => c.String());
        }
    }
}
