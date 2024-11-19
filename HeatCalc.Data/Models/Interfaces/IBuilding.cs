using HeatCalc.Data.Models.Building;

namespace HeatCalc.Data.Models.Interfaces
{
    public interface IBuilding
    {
        Guid Id { get; set; }
        /// <summary>
        /// Наименование объекта
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        DateTime CreatedDateUtc { get; set; }
        /// <summary>
        /// Дата обновления
        /// </summary>
        DateTime UpdatedDateUtc { get; set; }
        /// <summary>
        /// Объем включая первый этаэ
        /// </summary>
        double VolumeIncludingFirstFloor { get; set; }
        /// <summary>
        /// Количество секций
        /// </summary>
        List<Section> Sections { get; set; }
        /// <summary>
        /// удаление с сохранение в БД
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
