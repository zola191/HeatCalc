using HeatCalcServer.Enums;

namespace HeatCalcServer.Domain
{
    public class Staircase
    {
        public TypeOfStaircase TypeOfTheStaircase { get; set; }
        /// <summary>
        /// Сообщение лестницы с индивидуальными тамбур-шлюзами
        /// </summary>
        public bool IsConnectTypicalFloorWithIndividualFireGateway { get; set; }
        /// <summary>
        /// Сообщение лестницы с пожаробезопасной зоной
        /// </summary>
        public bool IsConnectTypicalFloorWithFireProfZone { get; set; }
        /// <summary>
        /// Конструктивное разделение лестничной клетки для высотного здания
        /// </summary>
        public bool IsStructuralDivisionOfTheStaircase { get; set; }

    }
}
