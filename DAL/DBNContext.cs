using DAL.Models;
using DAL.Models.Identity;
using DAL.Models.Ref;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;

namespace DAL
{
    public class DBNContext : IdentityDbContext<ApplicationUser>
    {
        public DBNContext(): base("name=LocalContext")
        {

        }

        public static DBNContext Create()
        {
            return new DBNContext();
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
