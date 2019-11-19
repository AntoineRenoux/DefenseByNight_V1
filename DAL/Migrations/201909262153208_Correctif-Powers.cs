namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectifPowers : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Power", name: "DisciplineKey", newName: "Discipline_DisciplineKey");
            RenameIndex(table: "dbo.Power", name: "IX_DisciplineKey", newName: "IX_Discipline_DisciplineKey");
            AddColumn("dbo.Power", "DisciplineName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Power", "DisciplineName");
            RenameIndex(table: "dbo.Power", name: "IX_Discipline_DisciplineKey", newName: "IX_DisciplineKey");
            RenameColumn(table: "dbo.Power", name: "Discipline_DisciplineKey", newName: "DisciplineKey");
        }
    }
}
