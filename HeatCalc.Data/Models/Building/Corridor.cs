using HeatCalc.Data.Models.Architect;

namespace HeatCalc.Data.Models.Building
{
    public class Corridor
    {
        public Guid Id { get; set; }
        //сообщение коридора типового этажа с тамбур-шлюзом
        public bool IsConnectTypicalFloorWithFireGateway { get; set; }
        //сообщение коридора типового этажа с пожаробезопасной зоной
        public bool IsConnectTypicalFloorWithFireProfZone { get; set; }

        public Guid SectionId { get; set; }
        public SectionOld Section { get; set; }
    }
}
