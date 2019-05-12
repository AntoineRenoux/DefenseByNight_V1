using AutoMapper;
using DefenseByNight.Areas.AuthentificationManager.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class UserVMToDtoProfile : Profile
    {
        public UserVMToDtoProfile()
        {
            CreateMap<UserDTO, UserConnexionViewModel>();
            CreateMap<UserConnexionViewModel, UserDTO>();

            CreateMap<UserDTO, UserRegisterViewModel>();
            CreateMap<UserRegisterViewModel, UserDTO>();
        }
    }
}