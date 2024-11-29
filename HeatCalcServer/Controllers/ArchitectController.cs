using FluentValidation;
using HeatCalc.Domain.Dto.Request;
using HeatCalc.Domain.Interfaces;
using HeatCalcServer.Validators;
using Microsoft.AspNetCore.Mvc;

namespace HeatCalcServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArchitectController : ControllerBase
    {
        private readonly IArchitectService architectService;
        private readonly IValidator<BuildingRequest> buildingRequest;

        public ArchitectController(IArchitectService architectService, IValidator<BuildingRequest> buildingRequest)
        {
            this.architectService = architectService;
            this.buildingRequest = buildingRequest;
        }

        [HttpPost]
        public async Task<IActionResult> Create(BuildingRequest request)
        {
            var result = buildingRequest.Validate(request);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            var response = await architectService.CreateAsync(request);
            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var existingArchitectModel = await architectService.GetByIdAsync(id);
            return Ok(existingArchitectModel);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, BuildingRequest request)
        {
            var updatedArchitectModel = await architectService.UpdateAsync(id, request);
            return Ok(updatedArchitectModel);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await architectService.SoftDeleteAsync(id);
            return Ok();
        }
    }
}
