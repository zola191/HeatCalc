using HeatCalc.Data;
using HeatCalc.Domain.Dto.Request;
using HeatCalc.Domain.Dto.Response;
using HeatCalc.Domain.Factories;
using HeatCalc.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HeatCalc.Domain.Services
{
    public class ArchitectService : IArchitectService
    {
        private readonly BuildingFactory _buildingFactory;
        private readonly BuildingResponseFactory _buildingResponseFactory;
        private readonly ApplicationDbContext _dbContext;

        public ArchitectService(ApplicationDbContext dbContext, BuildingResponseFactory buildingResponseFactory,
            BuildingFactory buildingFactory)
        {
            _dbContext = dbContext;
            _buildingResponseFactory = buildingResponseFactory;
            _buildingFactory = buildingFactory;
        }

        public async Task<BuildingModel> CreateAsync(BuildingRequest request)
        {
            var building = _buildingFactory.CreateBuilding(request);

            await _dbContext.Buildings.AddAsync(building);
            await _dbContext.SaveChangesAsync();

            var buildingModel = _buildingResponseFactory.CreateBuildingModel(building);

            return buildingModel;

        }

        public async Task<BuildingModel> GetByIdAsync(Guid id)
        {
            var existingBuilding = await _dbContext.Buildings.FirstOrDefaultAsync(f => f.Id == id);
            if (existingBuilding != null)
            {
                return _buildingResponseFactory.CreateBuildingModel(existingBuilding);
            }
            return null;
        }

        public async Task SoftDeleteAsync(Guid id)
        {
            var existingBuilding = await _dbContext.Buildings.FirstOrDefaultAsync(f => f.Id == id);
            if (existingBuilding != null)
            {
                existingBuilding.IsDeleted = true;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<BuildingModel> UpdateAsync(Guid id, BuildingRequest request)
        {
            var existingBuilding = await _dbContext.Buildings.FirstOrDefaultAsync(f => f.Id == id);
            if (existingBuilding != null)
            {
                _buildingFactory.UpdateBuilding(request, existingBuilding);
                await _dbContext.SaveChangesAsync();

                return _buildingResponseFactory.UpdateBuildingModel(existingBuilding);
            }
            return null;
        }
    }
}
