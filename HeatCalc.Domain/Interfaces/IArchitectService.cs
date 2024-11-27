using HeatCalc.Domain.Dto.Request;
using HeatCalc.Domain.Dto.Response;

namespace HeatCalc.Domain.Interfaces
{
    public interface IArchitectService
    {
        Task<BuildingModel> CreateAsync(BuildingRequest request);
        Task<BuildingModel> GetByIdAsync(Guid id);
        Task<BuildingModel> UpdateAsync(Guid id, BuildingRequest request);
        Task SoftDeleteAsync(Guid id);
    }
}
