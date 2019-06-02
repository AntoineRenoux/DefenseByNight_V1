using AutoMapper;
using DTO;
using DefenseByNight.Areas.Rules.Models;

namespace DefenseByNight.Mapping
{
    public class FocusVmToDtoProfile: Profile
    {
        public FocusVmToDtoProfile()
        {
            CreateMap<FocusViewModel, FocusDto>();
            CreateMap<FocusDto, FocusViewModel>();
        }
    }
}