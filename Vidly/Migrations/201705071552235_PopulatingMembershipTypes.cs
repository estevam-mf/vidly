namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonth, DiscountRate, Name) VALUES (0, 0, 0, 'Pay As You Go')");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonth, DiscountRate, Name) VALUES (30, 1, 10, 'Monthly')");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonth, DiscountRate, Name) VALUES (90, 3, 15, 'Quaterly')");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonth, DiscountRate, Name) VALUES (300, 12, 20, 'Anual')");
        }
        
        public override void Down()
        {
        }
    }
}
