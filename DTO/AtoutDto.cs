using static Tools.EnumAtoutFlaw;

namespace DTO
{
    public class AtoutDto : IDto
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeAtout Type { get; set; }
        public int Cost { get; set; }
    }
}
