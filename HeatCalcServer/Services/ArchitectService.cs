using HeatCalcServer.Dto.Request;
using HeatCalcServer.Dto.Response;
using HeatCalcServer.Interfaces;

namespace HeatCalcServer.Services
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
