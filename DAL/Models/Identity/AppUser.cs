using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
