namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToCostumer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "BirthdayDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "BirthdayDate");
        }
    }
}
