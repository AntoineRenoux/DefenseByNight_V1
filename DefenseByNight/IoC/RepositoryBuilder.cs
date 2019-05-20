using Autofac;
using DAL;
using DAL.Repository.Ref;

namespace DefenseByNight.IoC
{
    public static class RepositoryBuilder
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<DBNContext>().As<IDataBaseContext>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(TraductionRepository).Assembly)
                  .AsImplementedInterfaces()
                  .InstancePerDependency();
        }
    }
}