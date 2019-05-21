using AutoMapper;
using BLL.Interfaces;
using DefenseByNight.Areas.Rules.Models;
using DefenseByNight.Controllers;
using DTO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DefenseByNight.Areas.Rules.Controllers
{
    [AllowAnonymous]
    public class DisciplinesController : BaseController
    {
        private readonly IPowerServices powerService;
        private readonly IDisciplineService disciplineService;

        public DisciplinesController(ITraductionService traductionService
            , IPowerServices powerService
            , IDisciplineService disciplineService) : base(traductionService)
        {
            this.powerService = powerService;
            this.disciplineService = disciplineService;
        }

        // GET: Rules/Disciplines
        public ActionResult Index()
        {
            var disciplines = disciplineService.GetAllWithPowers(CurrentUser.Lang);
            var model = Mapper.Map<List<DisciplineDto>, List<DisciplineViewModel>>(disciplines);
            
            return View(model);
        }
    }
}
