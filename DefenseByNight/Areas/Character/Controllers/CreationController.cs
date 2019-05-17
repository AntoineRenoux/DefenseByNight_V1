using System.Web.Mvc;

namespace DefenseByNight.Areas.Character.Controllers
{
    [Authorize]
    public class CreationController : Controller
    {
        // GET: Character/Create
        public ActionResult Index()
        {
            return View();
        }
    }
}