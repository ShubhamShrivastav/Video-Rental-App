namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'436af7fa-32b3-4682-8ef6-11d42dbf89f0', N'admin@vidly.com', 0, N'AOljs0Q1XH8Oe+lUw/L00ovTW4HhqzGjcPcHHq0lANPYmE8GZAkQ/6mT8zgvIocoXg==', N'2ea9d856-4e19-4502-977f-d014326d5a85', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c64a2fd3-35a0-4b8b-afcb-75b84e949ddd', N'guest@vidly.com', 0, N'AMfK1uPpqkgP/zW9VOWa72KMCdz+xMa73Pt4ZJEcU8nbBZ4MUIjppY10Ra3cgI4UDQ==', N'906be2b8-9aec-42ca-ace0-121ea1026b69', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ab0a767a-aafe-4134-ad25-a6664d20d0fa', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'436af7fa-32b3-4682-8ef6-11d42dbf89f0', N'ab0a767a-aafe-4134-ad25-a6664d20d0fa')

");
        }
        
        public override void Down()
        {
        }
    }
}
