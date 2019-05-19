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
        List<DisciplineDTO> GetAllWithPowers(int languageId);
    }
}
