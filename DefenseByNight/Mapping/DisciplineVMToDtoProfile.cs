using AutoMapper;
using DefenseByNight.Areas.Rules.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class DisciplineVMToDtoProfile : Profile
    {
        public DisciplineVMToDtoProfile()
        {
            CreateMap<DisciplineViewModel, DisciplineDto>();
            CreateMap<DisciplineDto, DisciplineViewModel>();
        }
    }
}