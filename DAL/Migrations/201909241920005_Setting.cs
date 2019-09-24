namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Setting : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Atout", "ClanKey", c => c.String(maxLength: 128));
            CreateIndex("dbo.Atout", "ClanKey");
            AddForeignKey("dbo.Atout", "ClanKey", "dbo.Clan", "ClanKey");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Atout", "ClanKey", "dbo.Clan");
            DropIndex("dbo.Atout", new[] { "ClanKey" });
            AlterColumn("dbo.Atout", "ClanKey", c => c.String());
        }
    }
}
