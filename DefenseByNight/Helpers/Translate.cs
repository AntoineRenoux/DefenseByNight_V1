using Autofac;
using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Interfaces.Ref;
using DAL.Repository.Ref;
using DTO;

namespace DefenseByNight.Helpers
{
    public static class Translate
    {
        public static TraductionDto GetTraduction(string key)
        {
            int lang = System.Globalization.CultureInfo.CurrentCulture.LCID;

            var result = new TraductionDto();
            result.LCID = lang;
            result.Key = key;
            result.Text = string.Empty;

            var builder = new ContainerBuilder();
            builder.RegisterType<TraductionService>().As<ITraductionService>();
            builder.RegisterType<TraductionRepository>().As<ITraductionRepository>();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<ITraductionService>();
                result = service.GetTraduction(key, lang);
            }
            return result;
        }

    }
}
