namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Atout",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                        Clan_ClanKey = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Clan", t => t.Clan_ClanKey)
                .Index(t => t.Clan_ClanKey);
            
            CreateTable(
                "dbo.Attribut",
                c => new
                    {
                        AttributKey = c.String(nullable: false, maxLength: 128),
                        AttributName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AttributKey);
            
            CreateTable(
                "dbo.Focus",
                c => new
                    {
                        FocusKey = c.String(nullable: false, maxLength: 128),
                        AttributKey = c.String(maxLength: 128),
                        FocusName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FocusKey)
                .ForeignKey("dbo.Attribut", t => t.AttributKey)
                .Index(t => t.AttributKey);
            
            CreateTable(
                "dbo.Clan",
                c => new
                    {
                        ClanKey = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        History = c.String(nullable: false),
                        Organisation = c.String(nullable: false),
                        Weakness = c.String(nullable: false),
                        RarityClan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClanKey);
            
            CreateTable(
                "dbo.Discipline",
                c => new
                    {
                        DisciplineKey = c.String(nullable: false, maxLength: 128),
                        DisciplineName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        TestScore = c.String(),
                    })
                .PrimaryKey(t => t.DisciplineKey);
            
            CreateTable(
                "dbo.Power",
                c => new
                    {
                        PowerName = c.String(nullable: false, maxLength: 128),
                        DisciplineName = c.String(),
                        DisciplineKey = c.String(maxLength: 128),
                        Level = c.Int(nullable: false),
                        System = c.String(nullable: false),
                        Description = c.String(),
                        FocusEffect = c.String(),
                        ExceptionalSuccess = c.String(),
                        Focus_FocusKey = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PowerName)
                .ForeignKey("dbo.Focus", t => t.Focus_FocusKey)
                .ForeignKey("dbo.Discipline", t => t.DisciplineKey)
                .Index(t => t.DisciplineKey)
                .Index(t => t.Focus_FocusKey);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.Traduction",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        CultureInfoId = c.Int(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => new { t.Key, t.CultureInfoId });
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.AspNetLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.ClanDiscipline",
                c => new
                    {
                        ClanKey = c.String(nullable: false, maxLength: 128),
                        DisciplineKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ClanKey, t.DisciplineKey })
                .ForeignKey("dbo.Clan", t => t.ClanKey, cascadeDelete: true)
                .ForeignKey("dbo.Discipline", t => t.DisciplineKey, cascadeDelete: true)
                .Index(t => t.ClanKey)
                .Index(t => t.DisciplineKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetRoles", "IdentityUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetLogins", "IdentityUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.IdentityUserClaim", "IdentityUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetRoles", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.ClanDiscipline", "DisciplineKey", "dbo.Discipline");
            DropForeignKey("dbo.ClanDiscipline", "ClanKey", "dbo.Clan");
            DropForeignKey("dbo.Power", "DisciplineKey", "dbo.Discipline");
            DropForeignKey("dbo.Power", "Focus_FocusKey", "dbo.Focus");
            DropForeignKey("dbo.Atout", "Clan_ClanKey", "dbo.Clan");
            DropForeignKey("dbo.Focus", "AttributKey", "dbo.Attribut");
            DropIndex("dbo.ClanDiscipline", new[] { "DisciplineKey" });
            DropIndex("dbo.ClanDiscipline", new[] { "ClanKey" });
            DropIndex("dbo.AspNetLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Power", new[] { "Focus_FocusKey" });
            DropIndex("dbo.Power", new[] { "DisciplineKey" });
            DropIndex("dbo.Focus", new[] { "AttributKey" });
            DropIndex("dbo.Atout", new[] { "Clan_ClanKey" });
            DropTable("dbo.ClanDiscipline");
            DropTable("dbo.AspNetLogins");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Traduction");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Power");
            DropTable("dbo.Discipline");
            DropTable("dbo.Clan");
            DropTable("dbo.Focus");
            DropTable("dbo.Attribut");
            DropTable("dbo.Atout");
        }
    }
}
