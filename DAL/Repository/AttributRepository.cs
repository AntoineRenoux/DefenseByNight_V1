using AutoMapper;
using DAL.Interfaces;
using DAL.Models.Ref;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository
{
    public class AttributRepository : BaseRepository<Attribute>, IAttributRepository
    {
        public AttributRepository()
        {
        }

        public List<AttributDTO> GetAll(int languageId)
        {
            var attribute = (from a in context.Attributs
                             join t in context.Traductions
                                 on a.AttributName equals t.Key
                             join t2 in context.Traductions
                                 on a.Description equals t2.Key
                             where t.LCID == languageId
                             select new AttributDTO
                             {
                                 AttributKey = a.AttributKey,
                                 Description = t2.Text,
                                 AttributName = t.Text,
                             }).ToList();

            var focus = (from f in context.Focus
                         join t in context.Traductions
                            on f.FocusName equals t.Key
                         join t2 in context.Traductions
                            on f.Description equals t2.Key
                         where t.LCID == languageId
                         select new FocusDTO
                         {
                             AttributKey = f.AttributKey,
                             FocusKey = f.FocusKey,
                             FocusName = t.Text,
                             Description = t2.Text
                         }).ToList();

            attribute.ForEach(a => {
                a.Focus = new List<FocusDTO>();
                a.Focus.AddRange(focus.Where(f => f.AttributKey == a.AttributKey));
            });

            return attribute;
        }
    }
}
