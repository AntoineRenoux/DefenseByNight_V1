using DTO;
using System;
using System.Linq;

namespace DAL
{
    public static class TraductionHelper
    {
        public static T Translate<T>(this T objetToTranslate, DbnContext context, int languageId) where T : class, IDto
        {
            if(objetToTranslate != null)
            {
                Type objetType = objetToTranslate.GetType();

                objetType.GetProperties().ToList().ForEach(prop => {

                    if (prop.PropertyType == typeof(string))
                    {
                        var propertyValue = prop.GetValue(objetToTranslate).ToString();
                        var traduction = context.Traductions.Where(trad => trad.Key == propertyValue && trad.LCID == languageId).FirstOrDefault();

                        if (traduction != null)
                            prop.SetValue(objetToTranslate, traduction.Text);
                    }
                });
            }
            return objetToTranslate;
        }
    }
}
