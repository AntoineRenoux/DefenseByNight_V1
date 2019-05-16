using DAL.Models;
using DAL.Models.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL
{
    public class IdentityContext : IdentityDbContext<AppUser>
    {
        public IdentityContext() : base("name=LocalIdentityContext")
        {

        }
    }
}
