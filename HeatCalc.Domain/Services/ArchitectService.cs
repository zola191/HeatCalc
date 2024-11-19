using HeatCalc.Domain.Dto.Request.Archive;
using HeatCalc.Domain.Dto.Response;
using HeatCalc.Domain.Interfaces;

namespace HeatCalc.Domain.Services
{
    public class ArchitectService : IArchitectService
    {
        public Task CreateAsync(ArchitectRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ArchitectModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ArchitectModel> UpdateAsync(Guid id, ArchitectRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
