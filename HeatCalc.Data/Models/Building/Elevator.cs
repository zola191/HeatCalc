using HeatCalc.Data.Consts;
using HeatCalc.Data.Models.Architect;

namespace HeatCalc.Data.Models.Building
{
    public class Elevator
    {
        public Guid Id { get; set; }
        public TypeOfElevator TypeOfElevator { get; set; }

        public Guid SectionId { get; set; }
        public SectionOld Section { get; set; }

        public Guid ParkingId { get; set; }
        public Parking Parking { get; set; }
    }
}
