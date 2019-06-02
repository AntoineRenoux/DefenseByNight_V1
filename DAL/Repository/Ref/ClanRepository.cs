using System.Collections.Generic;
using DAL.Interfaces.Ref;
using DAL.Models.Ref;
using DTO;
using System.Linq;


namespace DAL.Repository.Ref
{
    public class ClanRepository : BaseRepository<Clan>, IClanRepository
    {
        public List<ClanDto> GetAll()
        {
            var ret = (from c in context.Clans
                       join t in context.Traductions
                          on c.Name equals t.Key
                       join t1 in context.Traductions
                          on c.Surname equals t1.Key
                       join t2 in context.Traductions
                          on c.History equals t2.Key
                       join t3 in context.Traductions
                          on c.Organisation equals t3.Key
                       select new ClanDto
                       {
                           ClanKey = c.ClanKey,
                           History = t2.Text,
                           Name = t.Text,
                           Organisation = t3.Text,
                           Surname = t1.Text
                       }).ToList();

            return ret;
        }
    }
}
