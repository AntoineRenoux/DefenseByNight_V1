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
    public class DisciplinesController : BaseController
    {
        private readonly IDisciplineService disciplineService;

        public DisciplinesController(ITraductionService traductionService
            , IDisciplineService disciplineService) : base(traductionService)
        {
            this.disciplineService = disciplineService;
        }

        // GET: Rules/Disciplines
        public ActionResult Index()
        {
            var model = Mapper.Map<List<DisciplineDto>, List<DisciplineViewModel>>(disciplineService.GetAll(CurrentUser.Lang));
            
            return View(model);
        }
    }
}
