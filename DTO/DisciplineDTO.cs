using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DisciplineDTO
    {
        [Required]
        public string DisciplineKey { get; set; }

        [Required]
        public string DisciplineName { get; set; }

        [Required]
        public string Description { get; set; }

        public string TestScore { get; set; }

        public List<PowerDTO> Powers { get; set; }
    }
}
