using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Ref
{
    public class Bloodline
    {
        public int BloodlineId { get; set; }

        [Required]
        public string History { get; set; }

        [Required]
        public List<Discipline> Disciplines { get; set; }

        public Clan Clan { get; set; }
    }
}
