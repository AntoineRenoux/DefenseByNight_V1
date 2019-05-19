using AutoMapper;
using DefenseByNight.Areas.Rules.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class PowerVMToDtoProfile : Profile
    {
        public PowerVMToDtoProfile()
        {
            CreateMap<PowerDTO, PowerViewModel>();
            CreateMap<PowerViewModel, PowerDTO>();
        }
    }
}