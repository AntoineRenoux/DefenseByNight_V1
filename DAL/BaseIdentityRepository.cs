using DAL.Models.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace DAL
{
    public class BaseIdentityRepository<TEntity> where TEntity : class
    {
        protected readonly IdentityContext context;
        public static Func<UserManager<AppUser>> UserManagerFactory { get; private set; }

        public BaseIdentityRepository(IdentityContext context)
        {
            this.context = context;

            // configure the user manager
            UserManagerFactory = () =>
            {
                var usermanager = new UserManager<AppUser>(
                    new UserStore<AppUser>(new IdentityContext()));
                // allow alphanumeric characters in username
                usermanager.UserValidator = new UserValidator<AppUser>(usermanager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };

                return usermanager;
            };
        }
    }
}
