namespace FProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "PremiereDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Films", "PremiereВate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "PremiereВate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Films", "PremiereDate");
        }
    }
}
