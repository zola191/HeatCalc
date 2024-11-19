using HeatCalc.Domain.Dto.Request.Archive;
using Microsoft.AspNetCore.Mvc;

namespace HeatCalcServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeatCalcController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(ArchitectRequest request)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromRoute] Guid id, ArchitectRequest request)
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
