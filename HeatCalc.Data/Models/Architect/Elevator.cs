using HeatCalc.Data.Enums;

namespace HeatCalc.Data.Models.Architect
{
    public class Elevator
    {
        public int Id { get; set; }
        public TypeOfElevator TypeOfElevator { get; set; }
        public List<Section> Sections { get; set; }
        public List<Parking> Parkings { get; set; }
    }
}
