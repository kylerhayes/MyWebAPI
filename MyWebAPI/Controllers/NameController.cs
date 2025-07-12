//kyler hayes
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "Kyler Hayes" });
        }
    }
}