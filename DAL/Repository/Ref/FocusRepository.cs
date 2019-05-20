using AutoMapper;
using DAL.Interfaces;
using DAL.Models.Ref;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Ref
{
    public class FocusRepository : BaseRepository<Focus>, IFocusRepository
    {
        public FocusRepository()
        {
        }

        public List<FocusDto> GetAll(int languageId)
        {
            var focusList = (from f in context.Focus
                             join t in context.Traductions
                                on f.FocusName equals t.Key
                             join t2 in context.Traductions
                                on f.Description equals t2.Key
                             where t.LCID == languageId
                             select new FocusDto {
                                 FocusKey = f.FocusKey,
                                 FocusName = t.Text,
                                 Description = t2.Text,
                                 AttributKey = f.AttributKey
                             }).ToList();

            return focusList;
        }

        public FocusDto GetByKey(string key, int languageId)
        {
            var focus = (from f in context.Focus
                         join t in context.Traductions
                            on f.Description equals t.Key
                         join t2 in context.Traductions
                            on f.FocusName equals t2.Key
                         where f.FocusKey == key
                         && t.LCID == languageId
                         select new FocusDto {
                             FocusKey = f.FocusKey,
                             AttributKey = f.AttributKey,
                             Description = t.Text,
                             FocusName = t2.Text
                         }).FirstOrDefault();

            return focus;

        }
    }
}
