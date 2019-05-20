using BLL.Interfaces;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AttributService : IAttributService
    {
        private readonly IAttributRepository _attributRepository;

        public AttributService(IAttributRepository attributRepository)
        {
            _attributRepository = attributRepository;
        }

        public List<AttributDto> GetAll(int languageId) => _attributRepository.GetAll(languageId);
    }
}
