namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clans : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clan", "Affiliate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clan", "Affiliate");
        }
    }
}
