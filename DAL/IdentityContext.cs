using DAL.Models;
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
