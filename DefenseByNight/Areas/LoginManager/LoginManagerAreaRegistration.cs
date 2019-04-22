using System.Web.Mvc;

namespace DefenseByNight.Areas.LoginManager
{
    public class LoginManagerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LoginManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LoginManager_default",
                "LoginManager/{controller}/{action}/{id}",
                new { action = "Index", controller = "Login", id = UrlParameter.Optional }
            );
        }
    }
}