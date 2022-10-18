using Microsoft.AspNetCore.Mvc;
using Template.Domain.GasolineDomain;

namespace Template.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GasolineGeneratorController : ControllerBase
    {
        private readonly IGasolineDomain _gasolineDomain;

        public GasolineGeneratorController(IGasolineDomain gasolineDomain)
        {
            _gasolineDomain = gasolineDomain;
        }

        [HttpGet("Start")]
        public IActionResult Start()
        {
            return Ok(_gasolineDomain.Start());
        }

        [HttpGet("Stop")]
        public IActionResult Stop()
        {
            return Ok(_gasolineDomain.Stop());
        }

        [HttpGet("Refuel")]
        public IActionResult Refuel()
        {
            return Ok(_gasolineDomain.Refuel());
        }
    }
}
