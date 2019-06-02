using DTO;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IAtoutRepository
    {
        List<AtoutDto> GetAll();
    }
}
