using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClanDto
    {
        public string ClanKey { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string History { get; set; }
        public string Organisation { get; set; }

        public List<DisciplineDto> Disciplines { get; set; }
    }
}
