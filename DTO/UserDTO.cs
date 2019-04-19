using System;

namespace DTO
{
    public class UserDTO
    {
        public int? UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTimeOffset BirthDate { get; set; }
    }
}
