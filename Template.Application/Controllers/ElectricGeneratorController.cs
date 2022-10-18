using Microsoft.AspNetCore.Mvc;
using Template.Domain.ElectricDomain;

namespace Template.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElectricGeneratorController : ControllerBase
    {
        private readonly IElectricDomain _electricDomain;

        public ElectricGeneratorController(IElectricDomain electricDomain)
        {
            _electricDomain = electricDomain;
        }

        [HttpGet("Start")]
        public IActionResult Start()
        {
            return Ok(_electricDomain.Start());
        }

        [HttpGet("Stop")]
        public IActionResult Stop()
        {
            return Ok(_electricDomain.Stop());
        }

        [HttpGet("Refuel")]
        public IActionResult Refuel()
        {
            return Ok(_electricDomain.Refuel());
        }
    }
}
