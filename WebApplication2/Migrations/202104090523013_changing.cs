namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changing : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Imagings", "Image", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Imagings", "Image", c => c.Binary());
        }
    }
}
