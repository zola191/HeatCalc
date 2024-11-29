using HeatCalc.Domain.Dto.Request;
using HeatCalc.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HeatCalcServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeatCalcController : ControllerBase
    {
        private readonly ArchitectService ArchitectService;

        public HeatCalcController(ArchitectService architectService)
        {
            ArchitectService = architectService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(BuildingRequest request)
        {
            var result = await ArchitectService.CreateAsync(request);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] Guid id, BuildingRequest request)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            return Ok();
        }
    }
}
