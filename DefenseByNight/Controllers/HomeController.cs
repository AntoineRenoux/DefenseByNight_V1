using System.Web.Mvc;

namespace DefenseByNight.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}