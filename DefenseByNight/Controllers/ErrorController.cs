using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DefenseByNight.Controllers
{
    public class ErrorController : BaseController
    {
        // GET: Error
        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}