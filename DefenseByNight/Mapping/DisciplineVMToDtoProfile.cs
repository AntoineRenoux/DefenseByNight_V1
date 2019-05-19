using AutoMapper;
using DefenseByNight.Areas.Rules.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class DisciplineVMToDtoProfile : Profile
    {
        public DisciplineVMToDtoProfile()
        {
            CreateMap<DisciplineViewModel, DisciplineDTO>();
            CreateMap<DisciplineDTO, DisciplineViewModel>();
        }
    }
}