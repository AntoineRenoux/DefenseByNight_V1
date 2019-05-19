using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Ref
{
    public class Character
    {
        public int CharacterId { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
