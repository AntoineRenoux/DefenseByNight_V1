using BLL.Enum.Attributs;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IFocusService
    {
        /// <summary>
        /// Récupère tous les Focus.
        /// </summary>
        /// <param name="languageId">CTX_LANGUAGE_ID</param>
        /// <returns></returns>
        List<FocusDTO> GetAll(int languageId);
    }
}
