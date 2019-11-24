using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace DAL.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthDay { get; set; }
    }
}
