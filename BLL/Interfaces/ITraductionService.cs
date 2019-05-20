using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITraductionService
    {
        TraductionDto GetTraduction(string key, int lang);
    }
}
