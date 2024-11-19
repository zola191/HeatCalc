using HeatCalc.Data.Consts;
using HeatCalc.Data.Models.Architect;

namespace HeatCalc.Data.Models.Building
{
    public class Staircase
    {
        public Guid Guid { get; set; }
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


        public Guid SectionId { get; set; }
        public SectionOld Section { get; set; }
    }
}
