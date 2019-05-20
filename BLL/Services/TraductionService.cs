using BLL.Interfaces;
using DAL.Interfaces.Ref;
using DTO;

namespace BLL.Services
{
    public class TraductionService : ITraductionService
    {
        private readonly ITraductionRepository _traductionRepository;

        public TraductionService(ITraductionRepository traductionRepository)
        {
            _traductionRepository = traductionRepository;
        }

        public TraductionDto GetTraduction(string key, int lang) => _traductionRepository.GetTraduction(key, lang);
    }
}
