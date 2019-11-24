using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BloodlineDto : IDto
    {
        public string BloodlineKey { get; set; }
        public string History { get; set; }
        public List<DisciplineDto> Disciplines { get; set; }
        public string Weakness { get; set; }
        public ClanDto Clan { get; set; }
    }
}
