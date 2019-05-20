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
        List<FocusDto> GetAll(int languageId);

        /// <summary>
        /// Récupére et traduit un Focus
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        FocusDto GetByKey(string key, int languageId);
    }
}
