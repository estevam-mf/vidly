namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'10586f32-5e5c-4f19-8d90-63a0aeb088e6', N'guest@vidly.com', 0, N'AD/9YzQSnomFKmVgP49U5HFyFfPj8eTmYJyGhWxOx6f7Dg+/WGgI47QEG3Vej7oFkQ==', N'00ca2829-059f-4846-a529-e41d47a48793', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd656259-9f7a-4796-8ae3-88673ad1e0d1', N'admin@vidly.com', 0, N'AEzYUoiC56/LbnXIAKBcPdJOmG/w+NeqdnQkC4d0KbRa8v/ObtssfUS9H9V+oOcEbw==', N'd9f65ce6-dff3-42ca-978d-2baa19dc5a17', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'90808775-9386-4e44-b15f-c06dddaa5888', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fd656259-9f7a-4796-8ae3-88673ad1e0d1', N'90808775-9386-4e44-b15f-c06dddaa5888')

                ");

        }

    public override void Down()
        {
        }
    }
}
