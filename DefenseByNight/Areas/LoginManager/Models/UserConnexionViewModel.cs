using System.ComponentModel.DataAnnotations;

namespace DefenseByNight.Areas.LoginManager.Models
{
    public class UserConnexionViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }
    }
}