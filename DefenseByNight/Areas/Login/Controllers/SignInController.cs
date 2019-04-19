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
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Connexion(UserConnexionViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home", new { area = "Portal" });
            }

            return RedirectToAction("Index", "Reception");
        }
    }
}