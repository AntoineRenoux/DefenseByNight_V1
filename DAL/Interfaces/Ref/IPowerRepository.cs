using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.Ref
{
    public interface IPowerRepository
    {
        List<PowerDto> GetPowersByDiscipline(string disciplineKey, int languageId);
    }
}
