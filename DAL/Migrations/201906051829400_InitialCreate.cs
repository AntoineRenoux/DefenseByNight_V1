namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        ClanKey = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.Clan", t => t.ClanKey)
                .Index(t => t.ClanKey);
            
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
                "dbo.Traduction",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        CultureInfoId = c.Int(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => new { t.Key, t.CultureInfoId });
            
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
            DropForeignKey("dbo.ClanDiscipline", "DisciplineKey", "dbo.Discipline");
            DropForeignKey("dbo.ClanDiscipline", "ClanKey", "dbo.Clan");
            DropForeignKey("dbo.Power", "DisciplineKey", "dbo.Discipline");
            DropForeignKey("dbo.Power", "Focus_FocusKey", "dbo.Focus");
            DropForeignKey("dbo.Atout", "ClanKey", "dbo.Clan");
            DropForeignKey("dbo.Focus", "AttributKey", "dbo.Attribut");
            DropIndex("dbo.ClanDiscipline", new[] { "DisciplineKey" });
            DropIndex("dbo.ClanDiscipline", new[] { "ClanKey" });
            DropIndex("dbo.Power", new[] { "Focus_FocusKey" });
            DropIndex("dbo.Power", new[] { "DisciplineKey" });
            DropIndex("dbo.Focus", new[] { "AttributKey" });
            DropIndex("dbo.Atout", new[] { "ClanKey" });
            DropTable("dbo.ClanDiscipline");
            DropTable("dbo.Traduction");
            DropTable("dbo.Power");
            DropTable("dbo.Discipline");
            DropTable("dbo.Clan");
            DropTable("dbo.Focus");
            DropTable("dbo.Attribut");
            DropTable("dbo.Atout");
        }
    }
}
