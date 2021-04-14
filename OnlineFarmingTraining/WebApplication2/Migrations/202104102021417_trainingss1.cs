namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trainingss1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrainingApplications", "email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrainingApplications", "email", c => c.String(nullable: false));
        }
    }
}
