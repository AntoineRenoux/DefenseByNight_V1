using AutoMapper;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class TraductionEntityToDtoProfile : Profile
    {
        public TraductionEntityToDtoProfile()
        {
            CreateMap<Traduction, TraductionDTO>();
            CreateMap<TraductionDTO, Traduction>();
        }
    }
}
