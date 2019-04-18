using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DefenseByNight.Areas.Login.Controllers
{
    public class SignInController : Controller
    {
        private readonly IUserService _userService;

        public SignInController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Login/SignIn
        public ActionResult Index()
        {
            return View();
        }
    }
}