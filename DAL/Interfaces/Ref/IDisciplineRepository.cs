using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IDisciplineRepository
    {
        /// <summary>
        /// Récupère toutes les disciplines avec leurs pouvois.
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        List<DisciplineDto> GetAllWithPowers(int languageId);

        /// <summary>
        /// Récupère toutes les disciplines sans leurs pouvois.
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        List<DisciplineDto> GetAll(int languageId);

        /// <summary>
        /// Récupére une Discipline depuis sa Key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        DisciplineDto GetByKey(string key, int languageId);
    }
}
