using DAL.Interfaces;
using DAL.Models.Ref;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DisciplineRepository : BaseRepository<Discipline>, IDisciplineRepository
    {
        public DisciplineRepository()
        {
        }

        public List<DisciplineDTO> GetAllWithPowers(int languageId)
        {
            var disciplines = (from d in context.Disciplines
                               join t in context.Traductions
                                on d.DisciplineName equals t.Key
                               join t2 in context.Traductions
                                on d.Description equals t2.Key
                               where t.LCID == languageId
                               select new DisciplineDTO
                               {
                                   DisciplineKey = d.DisciplineKey,
                                   DisciplineName = t.Text,
                                   Description = t2.Text
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
                          select new PowerDTO
                          {
                              PowerName = t.Text,
                              Description = t2.Text,
                              DisciplineName = t6.Text,
                              ExceptionalSuccess= t3.Text,
                              Level = p.Level,
                              System = t4.Text,
                              FocusEffect = t5.Text,
                              DisciplineKey = p.DisciplineKey
                          }).ToList();


            disciplines.ForEach(d => {
                d.Powers = new List<PowerDTO>();
                d.Powers.AddRange(powers.Where(p => p.DisciplineKey == d.DisciplineKey));
            });

            return disciplines;
        }
    }
}
