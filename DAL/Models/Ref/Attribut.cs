using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Ref
{
    public class Attribut
    {
        [Key]
        public string AttributKey { get; set; }

        [Required]
        public string AttributName { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Focus> Focus { get; set; }
    }
}
