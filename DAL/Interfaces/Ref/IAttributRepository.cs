using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAttributRepository
    {
        List<AttributDto> GetAll(int languageId);
    }
}
