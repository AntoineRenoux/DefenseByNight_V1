using DTO;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IClanService
    {
        /// <summary>
        /// Récupère tout les Clans.
        /// </summary>
        /// <returns></returns>
        List<ClanDto> GetAll(int languageId);
    }
}
