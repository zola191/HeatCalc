using HeatCalc.Domain.Dto.Request.Archive;
using HeatCalc.Domain.Dto.Response;

namespace HeatCalc.Domain.Interfaces
{
    public interface IArchitectService
    {
        Task CreateAsync(ArchitectRequest request);
        Task<ArchitectModel> GetByIdAsync(Guid id);
        Task<ArchitectModel> UpdateAsync(Guid id, ArchitectRequest request);
        Task SoftDeleteAsync(Guid id);
    }
}
