using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IDisciplineRepository
    {
        /// <summary>
        /// Récupère toutes les disciplines et leurs pouvoirs.
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        List<DisciplineDto> GetAll(int languageId);
    }
}
