using HeatCalc.Data.Enums;

namespace HeatCalc.Data.Models.Architect
{
    public class Building
    {
        public Guid Id { get; set; }
        public BuildingType BuildingType { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        /// <summary>
        /// общий объем пожарного отсека секции включая первый этаж
        /// </summary>
        public double VolumeIncludingFirstFloor { get; set; }
        public List<Section> Sections { get; set; } = new List<Section>();
        
        /// <summary>
        /// Наличие автостоянки
        /// </summary>
        public bool HasParking { get; set; }
        /// <summary>
        /// Количество ворот для выезда из автостоянки
        /// </summary>
        public int? CountOfExitGateInParking { get; set; }
        /// <summary>
        /// Количество пожарных отсеков в автостоянке
        /// </summary>
        public int? CountFireCompartmentInParking { get; set; }
        /// <summary>
        /// Наличие изолированной рампы в автостоянке
        /// </summary>
        public bool? IsRampIsolated { get; set; }
        /// <summary>
        /// В каком пожарном отсеке рампа
        /// </summary>
        public int? NumberOfIsolatedRampInFireComaprtment { get; set; }
        /// <summary>
        /// Деление паркинга на пожарные отсеки
        /// </summary>
        public List<Parking>? Parkings { get; set; }

        public bool IsDeleted { get; set; }

        public Guid HeatId { get; set; }

        public Heat.Heat Heat { get; set; }
    }
}
