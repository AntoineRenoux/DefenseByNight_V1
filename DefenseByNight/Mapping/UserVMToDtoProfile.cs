using AutoMapper;
using DefenseByNight.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefenseByNight.Mapping
{
    public class UserVMToDtoProfile : Profile
    {
        public UserVMToDtoProfile()
        {
            CreateMap<UserDTO, UserConnexionViewModel>();
            CreateMap<UserConnexionViewModel, UserDTO>();
        }
    }
}