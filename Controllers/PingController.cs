using Microsoft.AspNetCore.Mvc;

namespace PrimerParcial.Controllers
{
    [ApiController]
    [Route("[controller]")] // Esto hace que el endpoint sea /ping
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("pong");
        }
    }
}