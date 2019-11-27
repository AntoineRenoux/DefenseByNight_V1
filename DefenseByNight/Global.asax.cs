using Autofac;
using Autofac.Integration.Mvc;
using Tools.Enum;
using DAL.Ioc;
using DefenseByNight.App_Start;
using DefenseByNight.IoC;
using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
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
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            //Autofac
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            RepositoryBuilder.Register(builder);
            ServiceBuilder.Register(builder);
            new AutofacContainer(builder.Build());
            DependencyResolver.SetResolver(new AutofacDependencyResolver(AutofacContainer.Instance));

            //Automapper
            AutoMapperConfig.Configure();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }
    }
}
