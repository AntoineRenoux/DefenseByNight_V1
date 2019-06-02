using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAtoutService
    {
        /// <summary>
        /// Permet de récupérer tout les atouts.
        /// </summary>
        /// <returns></returns>
        List<AtoutDto> GetAll();
    }
}
