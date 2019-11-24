using AutoMapper;
using DAL.Models.Ref;
using DTO;

namespace DAL.Mapping
{
    public class BloodlineEntityToDtoProfile : Profile
    {
        public BloodlineEntityToDtoProfile()
        {
            CreateMap<Bloodline, BloodlineDto>();
            CreateMap<BloodlineDto, Bloodline>();
        }
    }
}
