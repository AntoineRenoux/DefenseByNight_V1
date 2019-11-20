using System.Collections.Generic;
using DAL.Interfaces.Ref;
using DAL.Models.Ref;
using DTO;
using System.Linq;
using System.Data.Entity;
using AutoMapper;

namespace DAL.Repository.Ref
{
    public class ClanRepository : BaseRepository<Clan>, IClanRepository
    {
        public List<ClanDto> GetAll(int languageId)
        {
            var clans = context.Clans
                        .Include(d => d.Disciplines)
                        .Include(d => d.Disciplines.Select(p => p.Powers))
                        .Include(a => a.Atouts)
                        .ToList();

            var clansDto = Mapper.Map<List<Clan>, List<ClanDto>>(clans);

            clansDto.ForEach(clan => {
                clan.Translate(context, languageId);
                clan.Disciplines.ForEach(disci =>
                {
                    disci.Translate(context, languageId);
                    disci.Powers.ForEach(power =>
                    {
                        power.Translate(context, languageId);
                    });
                });

                clan.Atouts.ForEach(atout =>
                {
                    atout.Translate(context, languageId);
                });
            });

            return clansDto.OrderByDescending(x => x.RarityClan).ThenBy(x => x.Name).ToList();
        }
    }
}
