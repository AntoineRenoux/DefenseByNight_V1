using DefenseByNight.Filters;
using System.Web.Mvc;

namespace DefenseByNight.Controllers
{
    [UserAuthenticationFilter]
    public class HomeController : Controller
    {
        public ActionResult Index(int userId)
        {
            return View();
        }
    }
}