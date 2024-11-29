using HeatCalc.Data.Enums;

namespace HeatCalc.Data.Models.Architect
{
    public class SectionElevator
    {
        public Guid SectionId { get; set; }
        public Section Section { get; set; }

        public TypeOfElevator ElevatorId { get; set; }
        public Elevator Elevator { get; set; }

        //public List<SectionElevator> SectionElevators { get; set; }
    }
}
