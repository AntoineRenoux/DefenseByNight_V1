using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBNDBInitializer : DropCreateDatabaseIfModelChanges<DBNContext>
    {
        protected override void Seed(DBNContext context)
        {

            #region Traduction
            var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "GEN_LBL_SITE_NAME", Text = "Defence By Night"}
            };

            trad.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion

            #region Users
            var users = new List<User>
            {
                new User{Alias="Zesso", FirstName="Antoine", LastName="Renoux", BirthDate=new DateTime(1992, 2, 13), Email = "ant.renoux@gmail.com", Password = "5S5rtlEb$"},
                new User{Alias="So", FirstName="Sophie", LastName="Vennin", BirthDate=new DateTime(1984, 2, 24), Email = "sophievennin@gmail.com", Password = "5S5rtlEb$"},
                new User{Alias="B44", FirstName="Fabien", LastName="De Vienne", BirthDate=new DateTime(1991, 11, 2), Email = "fabien.devienne@gmail.com", Password = "5S5rtlEb$"}
            };

            users.ForEach(u =>
            {
                context.Users.Add(u);
            });

            context.SaveChanges();
            #endregion

        }
    }
}
