using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
