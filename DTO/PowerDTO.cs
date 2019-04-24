using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class PowerDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public string System { get; set; }

        [Required]
        public DisciplineDTO Discipline { get; set; }

        public string Description { get; set; }

        public FocusDTO Focus { get; set; }

        public string FocusEffect { get; set; }

        public string ExceptionalSuccess { get; set; }
    }
}
