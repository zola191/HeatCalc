namespace HeatCalcServer.Domain.Architect
{
    public class Architect
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование объекта
        /// </summary>
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        //сумма площадей всех секций жилого дома
        //public double TotalAreaOfApartments { get; set; }
        /// <summary>
        /// количество секций
        /// </summary>
        public int SectionsCount { get; set; }
        /// <summary>
        /// Объем включая первый этаэ
        /// </summary>
        public double VolumeIncludingFirstFloor { get; set; }
        /// <summary>
        /// Наличие паркинга
        /// </summary>
        public bool HasParking { get; set; }
        /// <summary>
        /// Наличие укрытия
        /// </summary>
        public bool HasShelter { get; set; }
        public List<Section> Sections { get; set; }

        /// <summary>
        /// данные по автостоянке
        /// количество пожарных отсеков в стоянке
        /// </summary>
        public int CountFireComaprtmentInParking { get; set; }
        /// <summary>
        /// количество наружных ворот рампы
        /// </summary>
        public int CountOfExitGateInParking { get; set; }
        /// <summary>
        /// Рампа изолированная?
        /// </summary>
        public bool IsIsolatedRamp { get; set; }
        /// <summary>
        /// В каком пожарном отсеке рампа
        /// </summary>
        public int NumberOfIsolatedRampInFireComaprtment { get; set; }
        /// <summary>
        /// Деление паркинга на пожарные отсеки
        /// </summary>
        public List<Parking> Parkings { get; set; }
        public bool IsDeleted { get; set; }
    }
}
