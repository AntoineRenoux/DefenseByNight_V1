using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Ref
{
    public class Traduction
    {
        [Key]
        [Column(Order = 1)]
        public string Key { get; set; }

        [Key]
        [Column("CultureInfoId", Order = 2)]
        public int LCID { get; set; }

        public string Text { get; set; }
    }
}
