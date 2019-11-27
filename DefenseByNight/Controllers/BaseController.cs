using BLL.Interfaces;
using DefenseByNight.Models;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Web.Mvc;

namespace DefenseByNight.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController()
        {
        }

        public AppUserModel CurrentUser
        {
            get {
                return new AppUserModel(this.User as ClaimsPrincipal);
            }
        }
    }
}