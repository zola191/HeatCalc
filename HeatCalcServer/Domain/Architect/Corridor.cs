namespace HeatCalcServer.Domain.Architect
{
    public class Corridor
    {
        //сообщение коридора типового этажа с тамбур-шлюзом
        public bool IsConnectTypicalFloorWithFireGateway { get; set; }
        //сообщение коридора типового этажа с пожаробезопасной зоной
        public bool IsConnectTypicalFloorWithFireProfZone { get; set; }
    }
}
