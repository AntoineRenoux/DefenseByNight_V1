using Autofac;
using BLL.Services;

namespace DefenseByNight.IoC
{
    public static class ServiceBuilder
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(TraductionService).Assembly)
                .AsImplementedInterfaces()
                .InstancePerDependency();
        }
    }
}