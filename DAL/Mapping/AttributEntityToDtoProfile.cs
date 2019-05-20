using AutoMapper;
using DAL.Models.Ref;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class AttributEntityToDtoProfile : Profile
    {
        public AttributEntityToDtoProfile()
        {
            CreateMap<Attribut, AttributDto>();
            CreateMap<AttributDto, Attribut>();
        }
    }
}
