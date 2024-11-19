using HeatCalc.Data.Models.Building;

namespace HeatCalc.Data.Models.Architect
{
    public class Architect
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование объекта
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Высотное здание или нет
        /// </summary>
        public bool HighRiseBuilding { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        //сумма площадей всех секций жилого дома
        //public double TotalAreaOfApartments { get; set; }
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
        public List<SectionOld> Sections { get; set; } = new List<SectionOld>();

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
        public List<Parking> Parkings { get; set; } = new List<Parking>();
        /// <summary>
        /// SoftDelete
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
