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
        private readonly IFocusService _focusService;
        private readonly IDisciplineService _disciplineService;

        public DisciplinesController(ITraductionService traductionService
            , IFocusService focusService
            , IDisciplineService disciplineService) : base(traductionService)
        {
            _focusService = focusService;
            _disciplineService = disciplineService;
        }

        // GET: Rules/Disciplines
        public ActionResult Index()
        {
            var disciplines = _disciplineService.GetAllWithPowers(CurrentUser.Lang);
            var model = Mapper.Map<List<DisciplineDTO>, List<DisciplineViewModel>>(disciplines);
            
            return View(model);
        }
    }
}