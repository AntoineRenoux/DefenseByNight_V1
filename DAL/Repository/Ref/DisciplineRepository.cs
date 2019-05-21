using DAL.Interfaces;
using DAL.Models.Ref;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Ref
{
    public class DisciplineRepository : BaseRepository<Discipline>, IDisciplineRepository
    {
        public DisciplineRepository()
        {
        }

        public List<DisciplineDto> GetAll(int languageId)
        {
            var disciplines = (from d in context.Disciplines
                               join t in context.Traductions
                                on d.DisciplineName equals t.Key
                               join t2 in context.Traductions
                                on d.Description equals t2.Key
                               join t3 in context.Traductions
                                on d.TestScore equals t3.Key
                               where t.LCID == languageId
                               select new DisciplineDto
                               {
                                   DisciplineKey = d.DisciplineKey,
                                   DisciplineName = t.Text,
                                   Description = t2.Text,
                                   TestScore = t3.Text
                               }).ToList();

            return disciplines;
        }

        public List<DisciplineDto> GetAllWithPowers(int languageId)
        {
            var disciplines = (from d in context.Disciplines
                               join t in context.Traductions
                                on d.DisciplineName equals t.Key
                               join t2 in context.Traductions
                                on d.Description equals t2.Key
                               join t3 in context.Traductions
                                on d.TestScore equals t3.Key
                               where t.LCID == languageId
                               select new DisciplineDto
                               {
                                   DisciplineKey = d.DisciplineKey,
                                   DisciplineName = t.Text,
                                   Description = t2.Text,
                                   TestScore = t3.Text
                               }).ToList();

            var powers = (from p in context.Powers
                          join t in context.Traductions
                            on p.PowerName equals t.Key
                          join t2 in context.Traductions
                            on p.Description equals t2.Key
                          join t3 in context.Traductions
                            on p.ExceptionalSuccess equals t3.Key
                          join t4 in context.Traductions
                            on p.System equals t4.Key
                          join t5 in context.Traductions
                            on p.FocusEffect equals t5.Key
                          join t6 in context.Traductions
                            on p.DisciplineName equals t6.Key
                          where t.LCID == languageId
                          select new PowerDto
                          {
                              PowerName = t.Text,
                              Description = t2.Text,
                              DisciplineName = t6.Text,
                              ExceptionalSuccess = t3.Text,
                              Level = p.Level,
                              System = t4.Text,
                              FocusEffect = t5.Text,
                              DisciplineKey = p.DisciplineKey,
                              Focus = new FocusDto
                              {
                                  AttributKey = p.Focus.AttributKey,
                                  FocusKey = p.Focus.FocusKey,
                                  Description = p.Focus.Description,
                                  FocusName = p.Focus.FocusName
                              }
                          }).ToList().OrderBy(x => x.Level);

            disciplines.ForEach(d => {
                d.Powers = new List<PowerDto>();
                d.Powers.AddRange(powers.Where(p => p.DisciplineKey == d.DisciplineKey));
            });

            return disciplines.OrderBy(x => x.DisciplineName).ToList();
        }

        public DisciplineDto GetByKey(string key, int languageId)
        {
            var discipline = (from d in context.Disciplines
                              join t in context.Traductions
                                on d.DisciplineName equals t.Key
                              join t2 in context.Traductions
                                on d.Description equals t2.Key
                              join t3 in context.Traductions
                                on d.TestScore equals t3.Key
                              where d.DisciplineKey == key
                              && t.LCID == languageId
                              select new DisciplineDto
                              {
                                   DisciplineKey = key,
                                   DisciplineName = t.Text,
                                   Description = t2.Text,
                                   TestScore = t3.Text
                              }).FirstOrDefault();

            return discipline;
        }
    }
}
