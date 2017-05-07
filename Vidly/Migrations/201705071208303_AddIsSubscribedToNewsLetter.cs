namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToNewsLetter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "IsSubscribedToNewsLetter");
        }
    }
}
