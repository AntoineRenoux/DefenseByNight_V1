using AutoMapper;
using DTO;
using DefenseByNight.Areas.Rules.Models;

namespace DefenseByNight.Mapping
{
    public class FocusVMToDtoProfile: Profile
    {
        public FocusVMToDtoProfile()
        {
            CreateMap<FocusViewModel, FocusDTO>();
            CreateMap<FocusDTO, FocusViewModel>();
        }
    }
}