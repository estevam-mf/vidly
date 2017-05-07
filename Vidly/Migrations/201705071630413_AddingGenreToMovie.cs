namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenreToMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenreModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MovieModels", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieModels", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieModels", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.MovieModels", "Genre_Id", c => c.Int());
            CreateIndex("dbo.MovieModels", "Genre_Id");
            AddForeignKey("dbo.MovieModels", "Genre_Id", "dbo.GenreModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieModels", "Genre_Id", "dbo.GenreModels");
            DropIndex("dbo.MovieModels", new[] { "Genre_Id" });
            DropColumn("dbo.MovieModels", "Genre_Id");
            DropColumn("dbo.MovieModels", "NumberInStock");
            DropColumn("dbo.MovieModels", "DateAdded");
            DropColumn("dbo.MovieModels", "ReleaseDate");
            DropTable("dbo.GenreModels");
        }
    }
}
