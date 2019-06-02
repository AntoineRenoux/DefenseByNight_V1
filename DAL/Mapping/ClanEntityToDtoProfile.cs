using AutoMapper;
using DAL.Models.Ref;
using DTO;

namespace DAL.Mapping
{
    public class ClanEntityToDtoProfile : Profile
    {
        public ClanEntityToDtoProfile()
        {
            CreateMap<Clan, ClanDto>();
            CreateMap<ClanDto, Clan>();
        }
    }
}
