using System.Web.Mvc;

namespace DefenseByNight.Areas.AuthentificationManager
{
    public class AuthentificationManagerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AuthentificationManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AuthentificationManager_default",
                "AuthentificationManager/{controller}/{action}/{id}",
                new { action = "Index", controller = "Login", id = UrlParameter.Optional }
            );
        }
    }
}