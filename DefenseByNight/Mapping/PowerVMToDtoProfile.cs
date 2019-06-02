using AutoMapper;
using DefenseByNight.Areas.Rules.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class PowerVmToDtoProfile : Profile
    {
        public PowerVmToDtoProfile()
        {
            CreateMap<PowerDto, PowerViewModel>();
            CreateMap<PowerViewModel, PowerDto>();
        }
    }
}