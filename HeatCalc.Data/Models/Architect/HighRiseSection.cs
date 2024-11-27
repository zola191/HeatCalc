namespace HeatCalc.Data.Models.Architect
{
    public class HighRiseSection
    {
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
