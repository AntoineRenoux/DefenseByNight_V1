using System.Collections.Generic;
using BLL.Interfaces;
using DAL.Interfaces.Ref;
using DTO;

namespace BLL.Services
{
    public class PowerService : IPowerServices
    {
        private readonly IPowerRepository powerRepository;

        public PowerService(IPowerRepository powerRepository)
        {
            this.powerRepository = powerRepository;
        }

        public List<PowerDto> GetPowersByDiscipline(string disciplineKey, int languageId) => powerRepository.GetPowersByDiscipline(disciplineKey, languageId);
    }
}
