using HeatCalc.Domain.Dto.Enums;

namespace HeatCalc.Domain.Dto.Request
{
    public class BuildingRequest
    {
        public BuildingTypeModel BuildingType { get; set; }
        public string Name { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public List<SectionRequest> Sections { get; set; }
        public bool HasParking { get; set; }
        public int? CountOfExitGateInParking { get; set; }
        public int? CountFireCompartmentInParking { get; set; }
        public bool? IsRampIsolated { get; set; }
        public int? NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<ParkingRequest>? Parkings { get; set; }
    }
}
