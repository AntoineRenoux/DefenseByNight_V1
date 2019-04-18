using Autofac;
using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefenseByNight.IoC
{
    public static class ServiceBuilder
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>();
        }
    }
}