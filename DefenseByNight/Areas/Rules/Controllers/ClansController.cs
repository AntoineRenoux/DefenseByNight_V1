using AutoMapper;
using BLL.Interfaces;
using DefenseByNight.Areas.Rules.Models;
using DefenseByNight.Controllers;
using DTO;
using System.Collections.Generic;
using System.Web.Mvc;
using Tools.Enum;

namespace DefenseByNight.Areas.Rules.Controllers
{
    [Authorize(Roles = EnumRoles.MEMBER)]
    public class ClansController : BaseController
    {
        private readonly IClanService clanService;

        public ClansController(IClanService clanService)
        {
            this.clanService = clanService;
        }

        // GET: Rules/Clans
        public ActionResult Index()
        {
            var model = Mapper.Map<List<ClanDto>, List<ClanViewModel>>(clanService.GetAll(CurrentUser.Lang));

            return View(model);
        }
    }
}