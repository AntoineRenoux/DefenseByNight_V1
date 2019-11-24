using DAL.Models.Identity;
using DAL.Models.Ref;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL
{
    public class DbnContext : IdentityDbContext<AppUser>, IDataBaseContext
    {
        public DbnContext(): base("name=LocalContext")
        {

        }

        #region References
        public DbSet<Traduction> Traductions { get; set; }

        public DbSet<Affiliate> Affiliates { get; set; }
        public DbSet<Attribut> Attributs { get; set; }
        public DbSet<Focus> Focus { get; set; }

        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Power> Powers { get; set; }

        public DbSet<Clan> Clans { get; set; }
        public DbSet<Atout> Atouts { get; set; }
        public DbSet<Bloodline> Bloodlines { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUserRole>()
                .HasKey(role => role.UserId)
                .ToTable("AspNetRoles");

            modelBuilder.Entity<IdentityUserLogin>()
                .HasKey(login => login.UserId)
                .ToTable("AspNetLogins");

            modelBuilder.Entity<IdentityUser>()
               .ToTable("AspNetUsers");

            modelBuilder.Entity<Clan>()
               .HasMany<Discipline>(d => d.Disciplines);
        }

    }
}
