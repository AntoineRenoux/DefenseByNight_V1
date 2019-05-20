using AutoMapper;
using DAL.Models.Identity;
using DTO;

namespace DAL.Mapping
{
    public class UserEntityToDtoProfile: Profile
    {
        public UserEntityToDtoProfile()
        {
            CreateMap<AppUser, UserDto>();
            CreateMap<UserDto, AppUser>();
        }
    }
}
