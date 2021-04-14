namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Imaging : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imagings",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.ImageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Imagings");
        }
    }
}
