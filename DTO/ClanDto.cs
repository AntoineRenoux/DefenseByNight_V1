using System.Collections.Generic;
using Tools;

namespace DTO
{
    public class ClanDto : IDto
    {
        public string ClanKey { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string History { get; set; }
        public string Organisation { get; set; }
        public string Weakness { get; set; }
        public EnumRarityClan RarityClan { get; set; }
        public string Affiliate { get; set; }

        public List<DisciplineDto> Disciplines { get; set; }
        public List<AtoutDto> Atouts { get; set; }
    }
}
