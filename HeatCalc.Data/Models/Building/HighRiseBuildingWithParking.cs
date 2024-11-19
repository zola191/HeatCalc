using HeatCalc.Data.Models.Interfaces;

namespace HeatCalc.Data.Models.Building
{
    public class HighRiseBuildingWithParking : IBuilding, 
        IHighRiseBuilding, IBuildingWithParking
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public List<Section> Sections { get; set; }
        public bool IsDeleted { get; set; }

        public List<HighRiseSection> HighRiseSections { get; set; }


        public int CountFireComaprtmentInParking { get; set; }
        public int CountOfExitGateInParking { get; set; }
        public bool IsIsolatedRamp { get; set; }
        public int NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<Parking> Parkings { get; set; }
    }
}
