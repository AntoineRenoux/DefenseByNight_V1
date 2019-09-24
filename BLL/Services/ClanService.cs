using System.Collections.Generic;
using BLL.Interfaces;
using DAL.Interfaces.Ref;
using DTO;

namespace BLL.Services
{
    public class ClanService : IClanService
    {
        private readonly IClanRepository clanRepository;

        public ClanService(IClanRepository clanRepository)
        {
            this.clanRepository = clanRepository;
        }

        public List<ClanDto> GetAll(int languageId) => clanRepository.GetAll(languageId);
    }
}
