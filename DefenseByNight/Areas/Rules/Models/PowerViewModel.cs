using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefenseByNight.Areas.Rules.Models
{
    public class PowerViewModel
    {
        public string PowerName { get; set; }
        public string DisciplineName { get; set; }
        public string DisciplineKey { get; set; }
        public int Level { get; set; }
        public string System { get; set; }
        public string Description { get; set; }
        public FocusViewModel Focus { get; set; }
        public string FocusEffect { get; set; }
        public string ExceptionalSuccess { get; set; }
    }
}