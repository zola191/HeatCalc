using HeatCalc.Data.Enums;

namespace HeatCalc.Data.Models.Architect
{
    public class Staircase
    {
        public Guid Id { get; set; }
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
        public List<SectionStaircase> SectionStaircases { get; set; }
    }
}
