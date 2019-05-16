using BLL.Interfaces;
using System.Security.Claims;
using System.Web.Mvc;

namespace DefenseByNight.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ITraductionService traductionService) : base(traductionService)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}