namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GenreModels", "Name", c => c.String(nullable: false));
            Sql("INSERT INTO GenreModels (Name) VALUES ('Action')");
            Sql("INSERT INTO GenreModels (Name) VALUES ('Family')");
            Sql("INSERT INTO GenreModels (Name) VALUES ('Romance')");
            Sql("INSERT INTO GenreModels (Name) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GenreModels", "Name", c => c.String());
        }
    }
}
