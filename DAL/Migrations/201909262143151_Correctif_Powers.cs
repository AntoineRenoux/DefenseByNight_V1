namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correctif_Powers : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Power", "DisciplineName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Power", "DisciplineName", c => c.String());
        }
    }
}
