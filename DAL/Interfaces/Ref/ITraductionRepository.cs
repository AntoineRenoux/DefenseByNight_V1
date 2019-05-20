using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.Ref
{
    public interface ITraductionRepository
    {
        TraductionDto GetTraduction(string key, int lang);
    }
}
