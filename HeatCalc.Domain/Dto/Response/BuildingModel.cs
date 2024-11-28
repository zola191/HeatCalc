using HeatCalc.Domain.Dto.Enums;

namespace HeatCalc.Domain.Dto.Response
{
    public class BuildingModel
    {
        public Guid Id { get; set; }
        public BuildingTypeModel BuildingTypeModel { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public List<SectionModel> Sections { get; set; }
        public bool HasParking { get; set; }
        public int? CountOfExitGateInParking { get; set; }
        public int? CountFireCompartmentInParking { get; set; }
        public bool? IsRampIsolated { get; set; }
        public int? NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<ParkingModel>? Parkings { get; set; }
    }
}
