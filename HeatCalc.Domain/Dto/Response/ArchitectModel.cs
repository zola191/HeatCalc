namespace HeatCalc.Domain.Dto.Response
{
    public class ArchitectModel
    {
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public int SectionsCount { get; set; }
        public double VolumeIncludingFirstFloor { get; set; }
        public bool HasParking { get; set; }
        public bool HasShelter { get; set; }
        public List<SectionModel> Sections { get; set; }
        public int CountFireComaprtmentInParking { get; set; }
        public int CountOfExitGateInParking { get; set; }
        public bool IsIsolatedRamp { get; set; }
        public int NumberOfIsolatedRampInFireComaprtment { get; set; }
        public List<ParkingModel> Parkings { get; set; }
    }
}
