using HeatCalc.Data.Models.Interfaces;

namespace HeatCalc.Data.Models.Building
{
    public class Building : IBuilding
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public List<Section> Sections { get; set; }
        public bool IsDeleted { get; set; }
    }
}
