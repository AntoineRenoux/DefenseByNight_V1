using AutoMapper;
using DAL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefenseByNight.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x => {
                x.AddProfile<UserEntityToDtoProfile>();
            });
        }
    }
}