using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class AttributDto : IDto
    {
        [Required]
        public string AttributKey { get; set; }

        [Required]
        public string AttributName { get; set; }

        [Required]
        public string Description { get; set; }

        public List<FocusDto> Focus { get; set; }

    }
}
