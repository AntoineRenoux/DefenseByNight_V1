using System.Collections.Generic;

namespace DefenseByNight.Areas.Rules.Models
{
    public class DisciplineViewModel
    {
        public string DisciplineKey { get; set; }
        public string DisciplineName { get; set; }
        public string Description { get; set; }
        public string TestScore { get; set; }
        public List<PowerViewModel> Powers { get; set; }
    }
}