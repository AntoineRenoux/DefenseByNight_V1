using DAL.Interfaces;
using DAL.Models.Ref;
using DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;

namespace DAL.Repository.Ref
{
    public class DisciplineRepository : BaseRepository<Discipline>, IDisciplineRepository
    {
        public DisciplineRepository()
        {
        }

        public List<DisciplineDto> GetAll(int languageId)
        {
            var disciplines = context.Disciplines
                                .Include(p => p.Powers)
                                .Include(p => p.Powers.Select(f => f.Focus))
                                .ToList();

            var disciplinesDto = Mapper.Map<List<Discipline>, List<DisciplineDto>>(disciplines);

            disciplinesDto.ForEach(disci =>
            {
                disci.Translate(context, languageId);
                disci.Powers.ForEach(power =>
                {
                    power.Translate(context, languageId);
                    power.Focus.Translate(context, languageId);
                });
            });

            return disciplinesDto.OrderBy(x => x.DisciplineName).ToList();
        }
    }
}
