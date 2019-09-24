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
            var ret = context.Clans.Include(x => x.Disciplines).Include(x => x.Atouts).ToList();

            ret.ForEach(clan =>
            {
                clan.Name = (from trad in context.Traductions
                             where trad.Key == clan.Name
                             && trad.LCID == languageId
                             select trad.Text).FirstOrDefault();

                clan.Affiliate = (from trad in context.Traductions
                                  where trad.Key == clan.Affiliate
                                  && trad.LCID == languageId
                                  select trad.Text).FirstOrDefault();

                clan.History = (from trad in context.Traductions
                                where trad.Key == clan.History
                                && trad.LCID == languageId
                                select trad.Text).FirstOrDefault();

                clan.Organisation = (from trad in context.Traductions
                                     where trad.Key == clan.Organisation
                                     && trad.LCID == languageId
                                     select trad.Text).FirstOrDefault();

                clan.Surname = (from trad in context.Traductions
                                where trad.Key == clan.Surname
                                && trad.LCID == languageId
                                select trad.Text).FirstOrDefault();

                clan.Weakness = (from trad in context.Traductions
                                 where trad.Key == clan.Weakness
                                 && trad.LCID == languageId
                                 select trad.Text).FirstOrDefault();

                clan.Disciplines.ToList().ForEach(disci =>
                {
                    disci.Description = (from trad in context.Traductions
                                         where trad.Key == disci.Description
                                         && trad.LCID == languageId
                                         select trad.Text).FirstOrDefault();

                    disci.DisciplineName = (from trad in context.Traductions
                                            where trad.Key == disci.DisciplineName
                                            && trad.LCID == languageId
                                            select trad.Text).FirstOrDefault();

                    disci.TestScore = (from trad in context.Traductions
                                       where trad.Key == disci.TestScore
                                       && trad.LCID == languageId
                                       select trad.Text).FirstOrDefault();
                });
            });

            return Mapper.Map<List<Clan>, List<ClanDto>>(ret);
        }
    }
}
