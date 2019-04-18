using AutoMapper;
using DAL.Interfaces;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TraductionRepository : BaseRepository<Traduction>, ITraductionRepository
    {
        public TraductionRepository(DBNContext context) : base(context)
        {
        }

        public TraductionDTO GetTraduction(string key, int lang)
        {
            var traduction =  (from trad in context.Traductions
                   where trad.Key == key
                   && trad.LCID == lang
                   select trad).FirstOrDefault();

            return Mapper.Map<Traduction, TraductionDTO>(traduction);
        }
    }
}
