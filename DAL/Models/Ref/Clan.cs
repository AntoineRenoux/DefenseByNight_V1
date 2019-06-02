using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Ref
{
    public class Clan
    {
        [Key]
        public string ClanKey { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string History { get; set; }

        [Required]
        public string Organisation { get; set; }

        [Required]
        public string Weakness { get; set; }

        public virtual ICollection<Discipline> Disciplines { get; set; }
        public virtual ICollection<Atout> Atouts { get; set; }
    }
}
