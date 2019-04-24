using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Ref
{
    public class Focus
    {
        [Key]
        public string FocusKey { get; set; }

        public string AttributKey { get; set; }

        [Required]
        public string FocusName { get; set; }

        [Required]
        public string Description { get; set; }

        
    }
}
