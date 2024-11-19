using HeatCalc.Data.Models.Interfaces;

namespace HeatCalc.Data.Models.Building
{
    public class HighRiseBuilding : IBuilding, IHighRiseBuilding
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public List<Section> Sections { get; set; }
        public bool IsDeleted { get; set; }

        public List<HighRiseSection> HighRiseSections { get; set; }

    }
}
