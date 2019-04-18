using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Traduction
    {
        [Key]
        [Column(Order = 1)]
        public string Key { get; set; }

        [Required]
        [Key]
        [Column("CultureInfoId", Order = 2)]
        public int LCID { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
