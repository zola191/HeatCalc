namespace HeatCalcServer.Dto.Request
{
    public class ArchitectReq
    {
        public string Name { get; set; }
        public int SectionsCount { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public bool HasParking { get; set; }
        public bool HasShelter { get; set; }
        public List<SectionRequest> Sections { get; set; }
        public int CountFireComaprtmentInParking { get; set; }
        public int CountOfExitGateInParking { get; set; }
        public bool IsIsolatedRamp { get; set; }
        public int NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<ParkingRequest> Parkings { get; set; }
    }
}
