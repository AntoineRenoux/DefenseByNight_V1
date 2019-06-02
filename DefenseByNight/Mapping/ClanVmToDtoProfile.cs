using AutoMapper;
using DefenseByNight.Areas.Rules.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class ClanVmToDtoProfile : Profile
    {
        public ClanVmToDtoProfile()
        {
            CreateMap<ClanDto, ClanViewModel>();
            CreateMap<ClanViewModel, ClanDto>();
        }
    }
}