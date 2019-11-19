namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectifPowe : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Power", name: "Discipline_DisciplineKey", newName: "DisciplineKey");
            RenameIndex(table: "dbo.Power", name: "IX_Discipline_DisciplineKey", newName: "IX_DisciplineKey");
            DropColumn("dbo.Power", "DisciplineName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Power", "DisciplineName", c => c.String());
            RenameIndex(table: "dbo.Power", name: "IX_DisciplineKey", newName: "IX_Discipline_DisciplineKey");
            RenameColumn(table: "dbo.Power", name: "DisciplineKey", newName: "Discipline_DisciplineKey");
        }
    }
}
