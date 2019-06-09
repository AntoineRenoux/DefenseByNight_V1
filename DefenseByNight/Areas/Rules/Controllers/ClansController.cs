using AutoMapper;
using BLL.Interfaces;
using DefenseByNight.Areas.Rules.Models;
using DefenseByNight.Controllers;
using DTO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DefenseByNight.Areas.Rules.Controllers
{
    [Authorize]
    public class ClansController : BaseController
    {
        private readonly IAtoutService atoutService;
        private readonly IClanService clanService;

        public ClansController(ITraductionService traductionService,
            IClanService clanService
            ,IAtoutService atoutService) : base(traductionService)
        {
            this.atoutService = atoutService;
            this.clanService = clanService;
        }

        // GET: Rules/Clans
        public ActionResult Index()
        {
            var model = Mapper.Map<List<ClanDto>, List<ClanViewModel>>(clanService.GetAll());

            return View();
        }
    }
}