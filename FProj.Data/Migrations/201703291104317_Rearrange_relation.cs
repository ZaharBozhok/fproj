namespace FProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rearrange_relation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "FilmId", "dbo.Films");
            DropIndex("dbo.Comments", new[] { "FilmId" });
            CreateIndex("dbo.Films", "UserIdCreator");
            AddForeignKey("dbo.Films", "UserIdCreator", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "UserIdCreator", "dbo.Users");
            DropIndex("dbo.Films", new[] { "UserIdCreator" });
            CreateIndex("dbo.Comments", "FilmId");
            AddForeignKey("dbo.Comments", "FilmId", "dbo.Films", "Id", cascadeDelete: true);
        }
    }
}
