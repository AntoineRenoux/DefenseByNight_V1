using BLL.Services;
using DTO;

namespace DefenseByNight.Helpers
{
    public static class Translate
    {
        public static TraductionDTO GetTraduction(string key)
        {
            int lang = System.Globalization.CultureInfo.CurrentCulture.LCID;

            var result = new TraductionDTO();
            result.LCID = lang;
            result.Key = key;
            result.Text = string.Empty;

            var builder = new ContainerBuilder();
            builder.RegisterType<TraductionService>().As<ITraductionService>();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<ITraductionService>();

                return service.GetTraduction(key, lang);
            }
        }

    }
}
