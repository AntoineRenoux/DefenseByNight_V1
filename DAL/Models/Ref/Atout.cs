using System.ComponentModel.DataAnnotations;
using static Tools.EnumAtoutFlaw;

namespace DAL.Models.Ref
{
    public class Atout
    {
        [Key]
        public string Key { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TypeAtout Type { get; set; }

        [Required]
        public int Cost { get; set; }
    }
}
