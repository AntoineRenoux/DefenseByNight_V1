using BLL.Enum;
using DefenseByNight.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace DefenseByNight.Areas.AuthentificationManager.Models
{
    public class UserRegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmePassword { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Alias { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset BirthDay { get; set; }
    }
}