using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces.Ref
{
    public interface IClanRepository
    {
        List<ClanDto> GetAll(int languageId);
    }
}
