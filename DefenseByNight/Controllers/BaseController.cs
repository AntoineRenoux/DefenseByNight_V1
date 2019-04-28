using BLL.Interfaces;
using DefenseByNight.Models;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Web.Mvc;

namespace DefenseByNight.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ITraductionService _traductionService;
        protected readonly UserManager<DAL.Models.AppUser> userManager;

        public BaseController(ITraductionService traductionService)
        {
            _traductionService = traductionService;
        }

        public AppUserModel CurrentUser
        {
            get {
                return new AppUserModel(this.User as ClaimsPrincipal);
            }
        }
    }
}