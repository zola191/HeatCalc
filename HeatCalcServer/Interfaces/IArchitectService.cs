using HeatCalcServer.Dto.Request;
using HeatCalcServer.Dto.Response;

namespace HeatCalcServer.Interfaces
{
    public interface IArchitectService
    {
        Task CreateAsync(ArchitectRequest request);
        Task<ArchitectModel> GetByIdAsync(Guid id);
        Task<ArchitectModel> UpdateAsync(Guid id, ArchitectRequest request);
        Task SoftDeleteAsync(Guid id);
    }
}
