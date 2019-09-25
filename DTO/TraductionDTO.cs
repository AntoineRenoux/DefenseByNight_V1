using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraductionDto : IDto
    {
        public string Key { get; set; }
        public string Text { get; set; }
        public int LCID { get; set; }
    }
}
