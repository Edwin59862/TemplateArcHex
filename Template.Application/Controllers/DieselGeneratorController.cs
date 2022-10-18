using Template.Domain.DieselDomain;
using Microsoft.AspNetCore.Mvc;

namespace Template.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DieselGeneratorController : ControllerBase
    {
        private readonly IDieselDomain _dieselDomain;

        public DieselGeneratorController(IDieselDomain dieselDomain)
        {
            _dieselDomain = dieselDomain;
        }


        [HttpGet("Start")]
        public IActionResult Start()
        {
            return Ok(_dieselDomain.Start());
        }

        [HttpGet("Stop")]
        public IActionResult Stop()
        {
            return Ok(_dieselDomain.Stop());
        }

        [HttpGet("Refuel")]
        public IActionResult Refuel()
        {
            return Ok(_dieselDomain.Refuel());
        }
    }
}
