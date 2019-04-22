using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Récupère tous les utilisateurs.
        /// </summary>
        /// <returns>Liste des utilisateurs</returns>
        List<UserDTO> GetAll();

        /// <summary>
        /// Récupére un utilisateur lors de son identification
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        UserDTO GetSignUpUser(UserDTO userDTO);
    }
}
