using HeatCalc.Domain.Dto.Enums;

namespace HeatCalc.Domain.Dto.Request
{
    public class BuildingRequest
    {
        public BuildingTypeModel BuildingType { get; set; }
        public string Name { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public List<SectionRequest> Sections { get; set; }
        //public bool IsHighRiseSection { get; set; }
        //public List<HighRiseSectionRequest>? HighRiseSections { get; set; }
        public bool HasParking { get; set; }
        public int? CountOfExitGateInParking { get; set; }
        public int? CountFireComaprtmentInParking { get; set; }
        public bool? IsIsolatedRamp { get; set; }
        public int? NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<ParkingRequest>? Parkings { get; set; }
        //public bool HasShelter { get; set; }
        //public List<ShelterRequest>? Shelters { get; set; }
    }
}
