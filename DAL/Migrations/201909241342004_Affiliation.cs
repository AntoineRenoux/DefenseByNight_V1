namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Affiliation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Affiliate",
                c => new
                    {
                        AffiliateKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AffiliateKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Affiliate");
        }
    }
}
