using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IFocusRepository
    {

        /// <summary>
        /// Récupère tous les Focus.
        /// </summary>
        /// <param name="languageId">CTX_LANGUAGE_ID</param>
        /// <returns></returns>
        List<FocusDTO> GetAll(int languageId);
    }
}
