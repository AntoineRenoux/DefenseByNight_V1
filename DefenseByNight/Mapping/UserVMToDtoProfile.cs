using AutoMapper;
using DefenseByNight.Areas.AuthentificationManager.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class UserVMToDtoProfile : Profile
    {
        public UserVMToDtoProfile()
        {
            CreateMap<UserDto, UserConnexionViewModel>();
            CreateMap<UserConnexionViewModel, UserDto>();

            CreateMap<UserDto, UserRegisterViewModel>();
            CreateMap<UserRegisterViewModel, UserDto>();
        }
    }
}