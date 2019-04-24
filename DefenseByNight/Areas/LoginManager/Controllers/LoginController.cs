using BLL.Enum;
using BLL.Interfaces;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using AutoMapper;
using DTO;
using DefenseByNight.Areas.LoginManager.Models;
using DefenseByNight.Controllers;

namespace DefenseByNight.Areas.LoginManager.Controllers
{
    public class LoginController : BaseController
    {
        private readonly ITraductionService _traductionService;
        private readonly IUserService _userService;

        public LoginController(ITraductionService traductionService, IUserService userService)
        {
            _traductionService = traductionService;
            _userService = userService;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var traductions = new Dictionary<string, string>
            {
                { EnumRessource.GEN_LBL_SITE_NAME, _traductionService.GetTraduction(EnumRessource.GEN_LBL_SITE_NAME, CTX_LANGUAGE_ID).Text },
                { EnumRessource.GEN_LBL_CONNEXION, _traductionService.GetTraduction(EnumRessource.GEN_LBL_CONNEXION, CTX_LANGUAGE_ID).Text },
                { EnumRessource.GEN_LBL_REGISTRATION, _traductionService.GetTraduction(EnumRessource.GEN_LBL_REGISTRATION, CTX_LANGUAGE_ID).Text },

                { EnumRessource.GEN_LBL_EMAIL, _traductionService.GetTraduction(EnumRessource.GEN_LBL_EMAIL, CTX_LANGUAGE_ID).Text },
                { EnumRessource.GEN_LBL_PASSWORD, _traductionService.GetTraduction(EnumRessource.GEN_LBL_PASSWORD, CTX_LANGUAGE_ID).Text },
                { EnumRessource.GEN_LBL_FIRSTNAME, _traductionService.GetTraduction(EnumRessource.GEN_LBL_FIRSTNAME, CTX_LANGUAGE_ID).Text },
                { EnumRessource.GEN_LBL_LASTNAME, _traductionService.GetTraduction(EnumRessource.GEN_LBL_LASTNAME, CTX_LANGUAGE_ID).Text },
                { EnumRessource.GEN_LBL_ALIAS, _traductionService.GetTraduction(EnumRessource.GEN_LBL_ALIAS, CTX_LANGUAGE_ID).Text },
                { EnumRessource.GEN_LBL_BIRTHDATE, _traductionService.GetTraduction(EnumRessource.GEN_LBL_BIRTHDATE, CTX_LANGUAGE_ID).Text },

                { EnumErrorsMessages.ERR_EMAIL_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_EMAIL_MISSING, CTX_LANGUAGE_ID).Text },
                { EnumErrorsMessages.ERR_PASSWORD_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_PASSWORD_MISSING, CTX_LANGUAGE_ID).Text },
                { EnumErrorsMessages.ERR_ALIAS_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_ALIAS_MISSING, CTX_LANGUAGE_ID).Text },
                { EnumErrorsMessages.ERR_BIRTHDATE_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_BIRTHDATE_MISSING, CTX_LANGUAGE_ID).Text },
                { EnumErrorsMessages.ERR_FIRSTNAME_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_FIRSTNAME_MISSING, CTX_LANGUAGE_ID).Text },
                { EnumErrorsMessages.ERR_LASTNAME_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_LASTNAME_MISSING, CTX_LANGUAGE_ID).Text },
                { EnumErrorsMessages.ERR_PASSWORD_TO_SHORT, _traductionService.GetTraduction(EnumErrorsMessages.ERR_PASSWORD_TO_SHORT, CTX_LANGUAGE_ID).Text },

            };

            return View(traductions);
        }

        /// <summary>
        /// Permet de se connecter
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(UserConnexionViewModel model)
        {
            var result = new JsonResult();

            if (ModelState.IsValid)
            {
                var user = _userService.GetSignUpUser(Mapper.Map<UserConnexionViewModel, UserDTO>(model));
                if (user != null && user.UserId != null)
                {
                    Session[EnumSession.CurrentUserDto] = user;
                    result.Data = new { success = true };
                }
                else
                    result.Data = new { success = false, message = _traductionService.GetTraduction(EnumErrorsMessages.ERR_SIGNIN_FAIL.ToString(), CTX_LANGUAGE_ID).Text };
            }
            return result;
        }


        /// <summary>
        /// Permet de s'identifier
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UserRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
            }

            return View();
        }
    }
}