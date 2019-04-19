using BLL.Enum;
using BLL.Interfaces;
using DefenseByNight.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace DefenseByNight.Areas.Login.Controllers
{
    public class LoginController : Controller
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
            int langCurrent = ((CultureInfo)Session[EnumSession.Culture]).LCID;
            var traductions = new Dictionary<string, string>
            {
                { EnumRessource.GEN_LBL_SITE_NAME, _traductionService.GetTraduction(EnumRessource.GEN_LBL_SITE_NAME, langCurrent).Text },
                { EnumRessource.GEN_LBL_CONNEXION, _traductionService.GetTraduction(EnumRessource.GEN_LBL_CONNEXION, langCurrent).Text },
                { EnumRessource.GEN_LBL_REGISTRATION, _traductionService.GetTraduction(EnumRessource.GEN_LBL_REGISTRATION, langCurrent).Text },

                { EnumRessource.GEN_LBL_EMAIL, _traductionService.GetTraduction(EnumRessource.GEN_LBL_EMAIL, langCurrent).Text },
                { EnumRessource.GEN_LBL_PASSWORD, _traductionService.GetTraduction(EnumRessource.GEN_LBL_PASSWORD, langCurrent).Text },
                { EnumRessource.GEN_LBL_FIRSTNAME, _traductionService.GetTraduction(EnumRessource.GEN_LBL_FIRSTNAME, langCurrent).Text },
                { EnumRessource.GEN_LBL_LASTNAME, _traductionService.GetTraduction(EnumRessource.GEN_LBL_LASTNAME, langCurrent).Text },
                { EnumRessource.GEN_LBL_ALIAS, _traductionService.GetTraduction(EnumRessource.GEN_LBL_ALIAS, langCurrent).Text },
                { EnumRessource.GEN_LBL_BIRTHDATE, _traductionService.GetTraduction(EnumRessource.GEN_LBL_BIRTHDATE, langCurrent).Text },

                { EnumErrorsMessages.ERR_EMAIL_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_EMAIL_MISSING, langCurrent).Text },
                { EnumErrorsMessages.ERR_PASSWORD_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_PASSWORD_MISSING, langCurrent).Text },
                { EnumErrorsMessages.ERR_ALIAS_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_ALIAS_MISSING, langCurrent).Text },
                { EnumErrorsMessages.ERR_BIRTHDATE_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_BIRTHDATE_MISSING, langCurrent).Text },
                { EnumErrorsMessages.ERR_FIRSTNAME_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_FIRSTNAME_MISSING, langCurrent).Text },
                { EnumErrorsMessages.ERR_LASTNAME_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_LASTNAME_MISSING, langCurrent).Text },
                { EnumErrorsMessages.ERR_PASSWORD_TO_SHORT, _traductionService.GetTraduction(EnumErrorsMessages.ERR_PASSWORD_TO_SHORT, langCurrent).Text },

            };

            return View(traductions);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(UserConnexionViewModel model)
        {
            if (ModelState.IsValid)
            {
            }

            return View();
        }

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