using BLL.Interfaces;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public class DisciplineService : IDisciplineService
    {
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly IFocusRepository _focusRepository;

        public DisciplineService(IDisciplineRepository disciplineRepository
            , IFocusRepository focusRepository)
        {
            _disciplineRepository = disciplineRepository;
            _focusRepository = focusRepository;
        }

        public List<DisciplineDTO> GetAllWithPowers(int languageId)
        {
            var disciplines = _disciplineRepository.GetAllWithPowers(languageId);

            disciplines.ForEach(d =>
            {
                d.Powers.ForEach(p =>
                {
                    p.Focus = _focusRepository.GetByKey(p.Focus.FocusKey, languageId);
                });
            });

            return disciplines;
        }

    }
}
