using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TraductionService : ITraductionService
    {
        private readonly ITraductionRepository _traductionRepository;

        public TraductionService(ITraductionRepository traductionRepository)
        {
            _traductionRepository = traductionRepository;
        }

        public TraductionDTO GetTraduction(string key, int lang) => _traductionRepository.GetTraduction(key, lang);
    }
}
