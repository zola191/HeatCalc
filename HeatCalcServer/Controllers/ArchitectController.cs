using HeatCalcServer.Dto.Request;
using HeatCalcServer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HeatCalcServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchitectController : ControllerBase
    {
        private readonly IArchitectService architectService;

        public ArchitectController(IArchitectService architectService)
        {
            this.architectService = architectService;
        }

        // нужно ли разделять модельки на request и response

        [HttpPost("create")]
        public async Task<IActionResult> Create(ArchitectRequest request)
        {
            await architectService.CreateAsync(request);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var existingArchitectModel = await architectService.GetByIdAsync(id);
            return Ok(existingArchitectModel);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Create([FromRoute] Guid id, ArchitectRequest request)
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
