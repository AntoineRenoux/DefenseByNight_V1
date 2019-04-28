using DefenseByNight.Models;
using System.Security.Claims;
using System.Web.Mvc;

namespace DefenseByNight.WebViewPage
{
    public abstract class AppViewPage<TModel> : WebViewPage<TModel>
    {
        protected AppUserModel CurrentUser
        {
            get {
                return new AppUserModel(this.User as ClaimsPrincipal);
            }
        }
    }

    public abstract class AppViewPage : AppViewPage<dynamic>
    {
    }
}