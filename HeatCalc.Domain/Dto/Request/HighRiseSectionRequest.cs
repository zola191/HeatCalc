namespace HeatCalc.Domain.Dto.Request
{
    public class HighRiseSectionRequest
    {
        public double TotalAreaOfApartments { get; set; }
        public int IntermediateTechnicalFloorNumber { get; set; }
        public int UpperFireCompartmentNumber { get; set; }
        public int CountOfFloorsOfFireComaprtment { get; set; }
    }
}
