namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Int(nullable: false),
                        DurationInMonth = c.Int(nullable: false),
                        DiscountRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CustomerModels", "MembershipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.CustomerModels", "MembershipTypeId");
            AddForeignKey("dbo.CustomerModels", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerModels", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.CustomerModels", new[] { "MembershipTypeId" });
            DropColumn("dbo.CustomerModels", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
