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

            //1036 : Français

            var labels = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "GEN_LBL_SITE_NAME", Text = "Defense By Night"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_CONNEXION", Text = "Connexion"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_REGISTRATION", Text = "Inscription"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_FIRSTNAME", Text = "Prénom"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_LASTNAME", Text = "Nom de famille"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_EMAIL", Text = "Adresse mail"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_PASSWORD", Text = "Mot de passe"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_BIRTHDATE", Text = "Date de naissance"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_ALIAS", Text = "Pseudo"},
            };

            labels.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            var errorMessages = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "ERR_FIRSTNAME_MISSING", Text = "Le prénom n'est pas renseigné."},
                new Traduction{LCID = 1036, Key = "ERR_LASTNAME_MISSING", Text = "Le nom de famille n'est pas renseigné."},
                new Traduction{LCID = 1036, Key = "ERR_EMAIL_MISSING", Text = "L'adresse mail n'est pas renseignée."},
                new Traduction{LCID = 1036, Key = "ERR_PASSWORD_MISSING", Text = "Le mot de passe n'est pas renseigné."},
                new Traduction{LCID = 1036, Key = "ERR_BIRTHDATE_MISSING", Text = "La date de naissance n'est pas renseignée."},
                new Traduction{LCID = 1036, Key = "ERR_ALIAS_MISSING", Text = "Le pseudo n'est pas renseigné."},

                new Traduction{LCID = 1036, Key = "ERR_PASSWORD_TO_SHORT", Text = "Le mot de passe doit faire au moins 6 carractères."},

                new Traduction{LCID = 1036, Key = "ERR_SIGNIN_FAIL", Text = "L'adresse mail ou le mot de passe est incorrecte."},
            };

            errorMessages.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion

            #region Users
            var users = new List<User>
            {
                new User{Alias="Zesso", FirstName="Antoine", LastName="Renoux", BirthDate = new DateTimeOffset(1992, 2, 13, 0, 0, 0, new TimeSpan(0, 0, 0)), Email = "zesso@gmail.com", Password = "5S5rtlEb$"},
                new User{Alias="So", FirstName="Sophie", LastName="Vennin", BirthDate = new DateTimeOffset(1984, 2, 24, 0, 0, 0, new TimeSpan(0, 0, 0)), Email = "patato@gmail.com", Password = "5S5rtlEb$"},
                new User{Alias="B44", FirstName="Fabien", LastName="De Vienne", BirthDate = new DateTimeOffset(1991, 11, 2, 0, 0, 0, new TimeSpan(0, 0, 0)), Email = "bro@gmail.com", Password = "5S5rtlEb$"}
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
