﻿using AutoMapper;
using DAL.Mapping;
using DefenseByNight.Mapping;
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

                #region Traduction
                x.AddProfile<TraductionEntityToDtoProfile>();
                #endregion

                #region User
                x.AddProfile<UserVMToDtoProfile>();
                x.AddProfile<UserEntityToDtoProfile>();
                #endregion
            });
        }
    }
}