using AutoMapper;
using DefenseByNight.Areas.LoginManager.Models;
using DTO;

namespace DefenseByNight.Mapping
{
    public class UserVMToDtoProfile : Profile
    {
        public UserVMToDtoProfile()
        {
            CreateMap<UserDTO, UserConnexionViewModel>();
            CreateMap<UserConnexionViewModel, UserDTO>();

            CreateMap<UserDTO, UserRegistrationViewModel>();
            CreateMap<UserRegistrationViewModel, UserDTO>();
        }
    }
}