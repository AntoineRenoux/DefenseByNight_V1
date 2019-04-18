using BLL.Enum;
using BLL.Interfaces;
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
            ViewBag.Traductions = _traductionService.GetTraduction(EnumRessource.GEN_LBL_SITE_NAME, ((CultureInfo)Session[EnumSession.Culture]).LCID);
            return View();
        }
    }
}