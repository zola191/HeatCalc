
namespace HeatCalc.Data.Models.Architect
{
    public class SectionCorridor
    {
        public Guid SectionId { get; set; }
        public Section Section { get; set; }

        public Guid CorridorId { get; set; }
        public Corridor Corridor { get; set; }
    }
}
