using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDisciplineService
    {

        /// <summary>
        /// Récupère toutes les disciplines de jeu sans leurs pouvoirs.
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        List<DisciplineDto> GetAll(int languageId);

    }
}
