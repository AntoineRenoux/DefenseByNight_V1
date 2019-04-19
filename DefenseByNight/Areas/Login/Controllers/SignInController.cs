using BLL.Interfaces;
using DefenseByNight.Models;
using System.Web.Mvc;

namespace DefenseByNight.Areas.Login.Controllers
{
    public class SignInController : Controller
    {
        private readonly IUserService _userService;

        public SignInController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Connexion(UserConnexionViewModel model)
        {
            return RedirectToAction("Index", "Home", new { area = "Portal"});
        }
    }
}