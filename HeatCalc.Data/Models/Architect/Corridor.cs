namespace HeatCalc.Data.Models.Architect
{
    public class Corridor
    {
        public Guid Id { get; set; }
        //сообщение коридора типового этажа с тамбур-шлюзом
        public bool IsConnectTypicalFloorWithFireGateway { get; set; }
        //сообщение коридора типового этажа с пожаробезопасной зоной
        public bool IsConnectTypicalFloorWithFireProfZone { get; set; }

        public List<Section> Sections { get; set; }
    }
}
