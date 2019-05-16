using BLL.Services;
using DTO;

namespace DefenseByNight.Helpers
{
    public static class Translate
    {
        public static TraductionDTO GetTraduction(string key)
        {
            int lang = System.Globalization.CultureInfo.CurrentCulture.LCID;
            //return new TraductionService().GetTraduction(key, lang);
            return new TraductionDTO();
        }

    }
}