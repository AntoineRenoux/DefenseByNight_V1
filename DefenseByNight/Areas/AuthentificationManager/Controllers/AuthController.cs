using BLL.Enum;
using BLL.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;
using DefenseByNight.Controllers;
using DefenseByNight.Areas.AuthentificationManager.Models;
using System.Security.Claims;
using System.Web;
using Microsoft.AspNet.Identity;

namespace DefenseByNight.Areas.AuthentificationManager.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {

        public AuthController(ITraductionService traductionService) : base(traductionService)
        {

        }

        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new UserConnexionViewModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(UserConnexionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Don't do this in production!
            if (model.Email == "admin@admin.com" && model.Password == "password")
            {
                var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, "Ben"),
                new Claim(ClaimTypes.Email, "a@b.com"),
                new Claim(ClaimTypes.Country, "England")
            },
                    DefaultAuthenticationTypes.ApplicationCookie);

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }

            ModelState.AddModelError("", EnumErrorsMessages.ERR_SIGNIN_FAIL);
            return View();
        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("index", "home");
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }
    }
}