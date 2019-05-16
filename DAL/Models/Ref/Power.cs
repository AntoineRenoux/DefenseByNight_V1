using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models.Ref
{
    public class Power
    {
        [Key]
        public string PowerName { get; set; }

        public string DisciplineName { get; set; }

        public string DisciplineKey { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public string System { get; set; }

        public string Description { get; set; }

        public Focus Focus { get; set; }

        public string FocusEffect { get; set; }

        public string ExceptionalSuccess { get; set; }
    }
}
