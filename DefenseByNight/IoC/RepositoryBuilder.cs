using Autofac;
using DAL;
using DAL.Interfaces;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefenseByNight.IoC
{
    public static class RepositoryBuilder
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<DBNContext>().InstancePerLifetimeScope();

            #region Reference
            builder.RegisterType<TraductionRepository>().As<ITraductionRepository>();
            builder.RegisterType<AttributRepository>().As<IAttributRepository>();
            builder.RegisterType<FocusRepository>().As<IFocusRepository>();
            builder.RegisterType<DisciplineRepository>().As<IDisciplineRepository>();
            #endregion
        }
    }
}