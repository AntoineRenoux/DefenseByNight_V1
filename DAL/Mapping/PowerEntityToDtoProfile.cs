using AutoMapper;
using DAL.Models.Ref;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class PowerEntityToDtoProfile: Profile
    {
        public PowerEntityToDtoProfile()
        {
            CreateMap<PowerDto, Power>();
            CreateMap<Power, PowerDto>();
        }
    }
}
