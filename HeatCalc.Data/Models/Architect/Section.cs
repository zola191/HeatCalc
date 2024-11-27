namespace HeatCalc.Data.Models.Architect
{
    public class Section
    {
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
        /// Общая площадь технических помещений
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
        /// центр обслуживания населения
        /// </summary>
        public bool HasServiceCenter { get; set; }
        /// <summary>
        /// Общая площадь центра обслуживания населения
        /// </summary>
        public double TotalAreaOfServiceCenter { get; set; }
        /// <summary>
        /// количество этажей
        /// </summary>
        public int CountOfFloors { get; set; }
        /// <summary>
        /// номер пожарного отсека
        /// </summary>
        public int LowerFireCompartmentNumber { get; set; }
        /// <summary>
        /// количество этажей пожарного отсека
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
        /// Насосная(в пож.отсеке секции)
        /// </summary>
        public bool HasPumpingStationInSectionFireComaprtment { get; set; }

        /// <summary>
        /// Высотная секция?
        /// </summary>
        public bool IsHighRiseSection { get; set; }

        /// <summary>
        /// Общая площадь квартир пожарного отсека секции
        /// </summary>
        public double TotalAreaOfApartments { get; set; }
        /// <summary>
        /// номер этажа на котором устроен промежуточный этаж
        /// </summary>
        public int IntermediateTechnicalFloorNumber { get; set; }
        /// <summary>
        /// номер нижнего пожарного отсека
        /// </summary>
        public int UpperFireCompartmentNumber { get; set; }
        /// <summary>
        /// количество этажей пожарного отсека
        /// </summary>
        public int CountOfFloorsOfFireComaprtment { get; set; }
    }
}
