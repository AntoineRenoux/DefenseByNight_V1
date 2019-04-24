using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class FocusDTO
    {
        [Required]
        public string FocusKey { get; set; }

        [Required]
        public string AttributKey { get; set; }

        [Required]
        public string FocusName { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
