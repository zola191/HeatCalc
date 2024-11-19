using HeatCalc.Data.Models.Building;

namespace HeatCalc.Data.Models.Architect
{
    public interface ISection
    {
        public Guid Id { get; set; }
        /// <summary>
        /// номер секции в пределах дома
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Общая площадь квартир секции 2-24 этажа
        /// </summary>
        public double TotalAreaOfApartmentsBelow { get; set; }
        /// <summary>
        /// Общая площадь подвала
        /// </summary>
        public double TotalAreaOfBasement { get; set; }
        /// <summary>
        /// площадь технического пространства над подвалом секции в пожарном отсеке жилья
        /// </summary>
        public double TotalAreaOfTechnicalSpace { get; set; }
        /// <summary>
        /// Наличие ОДС/ЦПУ в секции
        /// </summary>
        public bool HasControlRoom { get; set; }
        /// <summary>
        /// Общая площадь ОДС/ЦПУ
        /// </summary>
        public double TotalAreaOfControlRoom { get; set; }
        /// <summary>
        /// наличие центра обслуживания населения
        /// </summary>
        public bool HasServiceCenter { get; set; }
        /// <summary>
        /// площадь центра обслуживания населения
        /// </summary>
        public double TotalAreaOfServiceCenter { get; set; }
        /// <summary>
        /// количество этажей
        /// </summary>
        public int CountOfFloors { get; set; }
        /// <summary>
        /// номер нижнего пожарного отсека
        /// </summary>
        public int LowerFireCompartmentNumber { get; set; }
        /// <summary>
        /// количество этажей нижнего пожарного отсека
        /// </summary>
        public int CountOfFloorsOfTheLowerFireComaprtment { get; set; }
        /// <summary>
        /// количество коридоров типового этажа
        /// </summary>
        public int CountOfCorridorsTypicalFloor { get; set; }
        /// <summary>
        /// количество пожаробезопасных зон
        /// </summary>
        public int CountOfFireproofZone { get; set; }
        public List<Corridor> Corridors { get; set; }
        public List<Staircase> Staircases { get; set; }
        public List<Elevator> Elevators { get; set; }

        /// <summary>
        /// номер пож.отсека, в котором расположен подвал секции
        /// </summary>
        public int BasementFireCompartmentNumber { get; set; }
        /// <summary>
        /// Насосная при нахождении (в пож.отсеке секции)
        /// </summary>
        public bool HasPumpingStationInSectionFireComaprtment { get; set; }
    }
}
