using DAL.Models;
using DAL.Models.Ref;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBNContext : DbContext
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

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
