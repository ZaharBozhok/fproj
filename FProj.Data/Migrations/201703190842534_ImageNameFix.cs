namespace FProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageNameFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Images", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Images", "Name", c => c.String());
        }
    }
}
