using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Ref
{
    public class Power
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public string System { get; set; }

        [Required]
        public Discipline Discipline { get; set; }

        public string Description { get; set; }

        public Focus Focus { get; set; }

        public string FocusEffect { get; set; }

        public string ExceptionalSuccess { get; set; }
    }
}
