using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Ref
{
    public class Bloodline
    {
        [Key]
        public string BloodlineKey { get; set; }

        [Required]
        public string History { get; set; }

        [Required]
        public List<Discipline> Disciplines { get; set; }

        public string Weakness { get; set; }

        public Clan Clan { get; set; }
    }
}
