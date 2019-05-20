using DAL.Interfaces.Ref;
using DAL.Models.Ref;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Ref
{
    public class PowerRepository : BaseRepository<Power>, IPowerRepository
    {
        public List<PowerDto> GetPowersByDiscipline(string disciplineKey, int languageId)
        {
            var powers = (from p in context.Powers
                          join t in context.Traductions
                            on p.PowerName equals t.Key
                          join t2 in context.Traductions
                            on p.DisciplineName equals t2.Key
                          join t3 in context.Traductions
                            on p.System equals t3.Key
                          join t4 in context.Traductions
                            on p.Description equals t4.Key
                          join t5 in context.Traductions
                            on p.FocusEffect equals t5.Key
                          join t6 in context.Traductions
                            on p.ExceptionalSuccess equals t6.Key
                          from f in context.Focus
                          join t7 in context.Traductions
                            on f.FocusName equals t7.Key
                          join t8 in context.Traductions
                            on f.Description equals t8.Key
                          where t.LCID == languageId
                          && p.DisciplineKey == disciplineKey
                          && f == p.Focus
                          select new PowerDto {
                              PowerName = t.Text,
                              DisciplineName = t2.Text,
                              System = t3.Text,
                              Description = t4.Text,
                              FocusEffect = t5.Text,
                              ExceptionalSuccess = t6.Text,
                              DisciplineKey = disciplineKey,
                              Level = p.Level,
                              Focus = new FocusDto
                              {
                                  AttributKey = f.AttributKey,
                                  Description = t8.Text,
                                  FocusKey = f.FocusKey,
                                  FocusName = t7.Text
                              }
                          }).ToList();

            return powers;
        }
    }
}
