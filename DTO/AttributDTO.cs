using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class AttributDTO
    {
        [Required]
        public string AttributKey { get; set; }

        [Required]
        public string AttributName { get; set; }

        [Required]
        public string Description { get; set; }

        public List<FocusDTO> Focus { get; set; }

    }
}
