using BLL.Interfaces;
using DefenseByNight.Filters;
using System.Web.Mvc;
using BLL.Enum;
using DTO;

namespace DefenseByNight.Controllers
{
    [UserAuthenticationFilter]
    public class HomeController : BaseController
    {
        private readonly ITraductionService _traductionService;
        private readonly IUserService _userService;
        private readonly IAttributService _attributService;
        private readonly IDisciplineService _disciplineService;

        public HomeController(ITraductionService traductionService
                                , IUserService userService
                                , IAttributService attributService
                                , IDisciplineService disciplineService)
        {
            _traductionService = traductionService;
            _userService = userService;
            _attributService = attributService;
            _disciplineService = disciplineService;
        }

        public ActionResult Index()
        {
            UserDTO currentUser = CTX_USER_DTO;

            ViewBag.Application = _traductionService.GetTraduction(EnumRessource.GEN_LBL_SITE_NAME, CTX_LANGUAGE_ID).Text;
            ViewBag.Disconnect = _traductionService.GetTraduction(EnumRessource.GEN_LBL_DISCONNECT, CTX_LANGUAGE_ID).Text;
            ViewBag.Account = _traductionService.GetTraduction(EnumRessource.GEN_LBL_ACCOUNT, CTX_LANGUAGE_ID).Text;

            ViewBag.FirstName = currentUser.FirstName;
            ViewBag.LastName = currentUser.LastName;

            var attributes = _attributService.GetAll(CTX_LANGUAGE_ID);
            var disciplines = _disciplineService.GetAllWithPowers(CTX_LANGUAGE_ID);

            return View(attributes);
        }
    }
}