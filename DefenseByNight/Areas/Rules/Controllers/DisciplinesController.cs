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
    public class DisciplinesController : BaseController
    {
        private readonly IDisciplineService disciplineService;

        public DisciplinesController(IDisciplineService disciplineService)
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
