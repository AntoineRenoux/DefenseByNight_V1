using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefenseByNight.Areas.Rules.Models
{
    public class ClanViewModel
    {
        public string ClanKey { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string History { get; set; }
        public string Organisation { get; set; }

        public List<DisciplineViewModel> Disciplines { get; set; }
    }
}