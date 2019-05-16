using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DefenseByNight.Areas.AuthentificationManager.Models
{
    public class UserConnexionViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }

        [Required]
        public DateTimeOffset BirthDay { get; set; }
    }
}