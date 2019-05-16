using AutoMapper;
using DAL.Interfaces;
using DAL.Models.Ref;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository
{
    public class FocusRepository : BaseRepository<Focus>, IFocusRepository
    {
        public FocusRepository()
        {
        }

        public List<FocusDTO> GetAll(int languageId)
        {
            var focusList = (from f in context.Focus
                             join t in context.Traductions
                                on f.FocusName equals t.Key
                             join t2 in context.Traductions
                                on f.Description equals t2.Key
                             select new FocusDTO {
                                 FocusKey = f.FocusKey,
                                 FocusName = t.Text,
                                 Description = t2.Text
                             }).ToList();

            return focusList;
        }
    }
}
