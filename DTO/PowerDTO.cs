using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class PowerDTO
    {
        [Required]
        public string PowerName { get; set; }

        public string DisciplineName { get; set; }

        public string DisciplineKey { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public string System { get; set; }

        public string Description { get; set; }

        public FocusDTO Focus { get; set; }

        public string FocusEffect { get; set; }

        public string ExceptionalSuccess { get; set; }
    }
}
