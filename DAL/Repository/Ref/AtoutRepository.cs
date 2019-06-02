using DAL.Interfaces;
using DAL.Models.Ref;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Ref
{
    public class AtoutRepository : BaseRepository<Atout>, IAtoutRepository
    {
        public List<AtoutDto> GetAll()
        {
            var atouts = (from a in context.Atouts
                          join t in context.Traductions
                             on a.Name equals t.Key
                          join t1 in context.Traductions
                             on a.Description equals t1.Key
                          select new AtoutDto
                          {
                              Key = a.Key,
                              Name = t.Text,
                              Description = t1.Text,
                              Cost = a.Cost,
                              Type = a.Type
                          }).ToList();

            return atouts;
        }
    }
}
