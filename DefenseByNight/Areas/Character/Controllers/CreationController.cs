using BLL.Interfaces;
using DefenseByNight.Controllers;
using System.Web.Mvc;

namespace DefenseByNight.Areas.Character.Controllers
{
    [Authorize]
    public class CreationController : BaseController
    {
        private readonly IFocusService _focusService;
        private readonly IDisciplineService _disciplineService;

        public CreationController(ITraductionService traductionService
            , IFocusService focusService
            , IDisciplineService disciplineService) : base(traductionService)
        {
            _focusService = focusService;
            _disciplineService = disciplineService;
        }

        // GET: Character/Create
        public ActionResult Index()
        {
            var focus = _focusService.GetAll(1036);
            return View();
        }
    }
}