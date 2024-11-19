using HeatCalc.Data.Models.Building;

namespace HeatCalc.Data.Models.Interfaces
{
    public interface IBuildingWithParking
    {
        /// <summary>
        /// данные по автостоянке
        /// количество пожарных отсеков в стоянке
        /// </summary>
        int CountFireComaprtmentInParking { get; set; }
        /// <summary>
        /// количество наружных ворот рампы
        /// </summary>
        int CountOfExitGateInParking { get; set; }
        /// <summary>
        /// Рампа изолированная?
        /// </summary>
        bool IsIsolatedRamp { get; set; }
        /// <summary>
        /// В каком пожарном отсеке рампа
        /// </summary>
        int NumberOfIsolatedRampInFireComaprtment { get; set; }
        /// <summary>
        /// Деление паркинга на пожарные отсеки
        /// </summary>
        List<Parking> Parkings { get; set; }
    }
}
