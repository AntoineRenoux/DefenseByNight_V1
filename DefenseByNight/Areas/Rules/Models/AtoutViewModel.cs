using static Tools.EnumAtoutFlaw;

namespace DefenseByNight.Areas.Rules.Models
{
    public class AtoutViewModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeAtout Type { get; set; }
        public int Cost { get; set; }
    }
}