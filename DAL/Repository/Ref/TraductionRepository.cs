using AutoMapper;
using DAL.Interfaces.Ref;
using DAL.Models.Ref;
using DTO;
using System.Linq;

namespace DAL.Repository.Ref
{
    public class TraductionRepository : BaseRepository<Traduction>, ITraductionRepository
    {
        public TraductionRepository()
        {
        }

        public TraductionDto GetTraduction(string key, int lang)
        {
            var traduction =  (from trad in context.Traductions
                   where trad.Key == key
                   && trad.LCID == lang
                   select trad).FirstOrDefault();

            return Mapper.Map<Traduction, TraductionDto>(traduction);
        }
    }
}
