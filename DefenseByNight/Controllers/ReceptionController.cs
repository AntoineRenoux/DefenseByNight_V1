using BLL.Enum;
using BLL.Interfaces;
using DefenseByNight.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace DefenseByNight.Areas.Login.Controllers
{
    public class ReceptionController : Controller
    {
        private readonly ITraductionService _traductionService;

        public ReceptionController(ITraductionService traductionService)
        {
            _traductionService = traductionService;
        }

        // GET: Login/Reception
        public ActionResult Index()
        {
            var model = new UserConnexionViewModel();

            int langCurrent = ((CultureInfo)Session[EnumSession.Culture]).LCID;
            var traductions = new Dictionary<string, string>
            {
                { EnumRessource.GEN_LBL_SITE_NAME, _traductionService.GetTraduction(EnumRessource.GEN_LBL_SITE_NAME, langCurrent).Text },
                { EnumRessource.GEN_LBL_CONNEXION, _traductionService.GetTraduction(EnumRessource.GEN_LBL_CONNEXION, langCurrent).Text },

                { EnumRessource.GEN_LBL_EMAIL, _traductionService.GetTraduction(EnumRessource.GEN_LBL_EMAIL, langCurrent).Text },
                { EnumRessource.GEN_LBL_PASSWORD, _traductionService.GetTraduction(EnumRessource.GEN_LBL_PASSWORD, langCurrent).Text },

                { EnumErrorsMessages.ERR_EMAIL_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_EMAIL_MISSING, langCurrent).Text },
                { EnumErrorsMessages.ERR_PASSWORD_MISSING, _traductionService.GetTraduction(EnumErrorsMessages.ERR_PASSWORD_MISSING, langCurrent).Text }
            };

            model.Traductions = traductions;

            return View(model);
        }
    }
}