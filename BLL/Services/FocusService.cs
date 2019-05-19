using BLL.Enum.Attributs;
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
    public class FocusService : IFocusService
    {
        private readonly IFocusRepository focusRepository;

        public FocusService(IFocusRepository _focusRepository)
        {
            focusRepository = _focusRepository;
        }

        public List<FocusDTO> GetAll(int languageId) => focusRepository.GetAll(languageId);

        public FocusDTO GetByKey(string key, int languageId) => focusRepository.GetByKey(key, languageId);
    }
}
