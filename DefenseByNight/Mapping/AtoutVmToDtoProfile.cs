using AutoMapper;
using DefenseByNight.Areas.Rules.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class AtoutVmToDtoProfile : Profile
    {
        public AtoutVmToDtoProfile()
        {
            CreateMap<AtoutDto, AtoutViewModel>();
            CreateMap<AtoutViewModel, AtoutDto>();
        }
    }
}