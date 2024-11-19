namespace HeatCalc.Data.Models.Architect
{
    public interface IHighRiseSection
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Общая площадь квартир в пределах пожарного отсека
        /// </summary>
        public double TotalAreaOfApartments { get; set; }
        /// <summary>
        /// на каком этаже промежуточный технический этаж
        /// </summary>
        public int IntermediateTechnicalFloorNumber { get; set; }
        /// <summary>
        /// номер пожарного отсека
        /// </summary>
        public int UpperFireCompartmentNumber { get; set; }
        /// <summary>
        /// количество этажей пожарного отсека
        /// </summary>
        public int CountOfFloorsOfFireComaprtment { get; set; }
    }
}
