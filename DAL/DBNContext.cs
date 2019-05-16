using DAL.Models.Ref;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL
{
    public class DBNContext : DbContext, IDataBaseContext
    {
        public DBNContext(): base("name=LocalContext")
        {

        }

        #region References
        public DbSet<Traduction> Traductions { get; set; }

        public DbSet<Attribut> Attributs { get; set; }
        public DbSet<Focus> Focus { get; set; }

        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Power> Powers { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
