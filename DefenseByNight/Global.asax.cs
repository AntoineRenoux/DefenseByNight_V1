using Autofac;
using Autofac.Integration.Mvc;
using DefenseByNight.App_Start;
using DefenseByNight.IoC;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DefenseByNight
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Autofac
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            RepositoryBuilder.Register(builder);
            ServiceBuilder.Register(builder);
            new AutofacContainer(builder.Build());
            DependencyResolver.SetResolver(new AutofacDependencyResolver(AutofacContainer.Instance));

            //Automapper
            AutoMapperConfig.Configure();
        }
    }
}
