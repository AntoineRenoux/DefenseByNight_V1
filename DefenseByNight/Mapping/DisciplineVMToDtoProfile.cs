using AutoMapper;
using DefenseByNight.Areas.Rules.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class DisciplineVmToDtoProfile : Profile
    {
        public DisciplineVmToDtoProfile()
        {
            CreateMap<DisciplineViewModel, DisciplineDto>();
            CreateMap<DisciplineDto, DisciplineViewModel>();
        }
    }
}