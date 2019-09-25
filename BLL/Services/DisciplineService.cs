using BLL.Interfaces;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public class DisciplineService : IDisciplineService
    {
        private readonly IDisciplineRepository disciplineRepository;
        private readonly IFocusRepository focusRepository;

        public DisciplineService(IDisciplineRepository disciplineRepository
            , IFocusRepository focusRepository)
        {
            this.disciplineRepository = disciplineRepository;
            this.focusRepository = focusRepository;
        }

        public List<DisciplineDto> GetAll(int languageId) => disciplineRepository.GetAll(languageId);
    }
}
