using Autofac;
using BLL.Interfaces;
using BLL.Services;

namespace DefenseByNight.IoC
{
    public static class ServiceBuilder
    {
        public static void Register(ContainerBuilder builder)
        {
            #region Identity
            #endregion

            #region Reference
            builder.RegisterType<TraductionService>().As<ITraductionService>();
            builder.RegisterType<AttributService>().As<IAttributService>();
            builder.RegisterType<FocusService>().As<IFocusService>();
            builder.RegisterType<DisciplineService>().As<IDisciplineService>();
            #endregion
        }
    }
}