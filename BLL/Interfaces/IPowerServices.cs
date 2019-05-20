using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPowerServices
    {
        /// <summary>
        /// Récupére tous les pouvoirs d'une discipline.
        /// </summary>
        /// <param name="disciplineKey"></param>
        /// <returns></returns>
        List<PowerDto> GetPowersByDiscipline(string disciplineKey, int languageId);
    }
}
