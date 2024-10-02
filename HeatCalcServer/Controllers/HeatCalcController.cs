using Microsoft.AspNetCore.Mvc;

namespace HeatCalcServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeatCalcController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(Guid id)
        {
            return Ok();
        }
    }
}
