using HeatCalc.Data.Models.Architect;

namespace HeatCalc.Data.Models.Building
{
    public class HighRiseSection : IHighRiseSection
    {
        public Guid Id { get; set; }
        public double TotalAreaOfApartments { get; set; }
        public int IntermediateTechnicalFloorNumber { get; set; }
        public int UpperFireCompartmentNumber { get; set; }
        public int CountOfFloorsOfFireComaprtment { get; set; }
    }
}
