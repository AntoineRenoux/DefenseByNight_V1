using DAL.Models.Ref;
using System.Data.Entity;

namespace DAL
{
    public interface IDataBaseContext
    {
        #region References
        DbSet<Traduction> Traductions { get; set; }

        DbSet<Attribut> Attributs { get; set; }
        DbSet<Focus> Focus { get; set; }

        DbSet<Discipline> Disciplines { get; set; }
        DbSet<Power> Powers { get; set; }
        #endregion
    }
}
