using BLL.Interfaces;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AtoutService : IAtoutService
    {
        private readonly IAtoutRepository atoutRepository;

        public AtoutService(IAtoutRepository atoutRepository)
        {
            this.atoutRepository = atoutRepository;
        }

        public List<AtoutDto> GetAll() => atoutRepository.GetAll();
    }
}
