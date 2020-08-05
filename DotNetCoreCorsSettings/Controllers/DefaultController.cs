using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CorsWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DefaultController : ControllerBase
    {
        [EnableCors("myCors")]
        public IActionResult Get()
        {
            return Ok("Sucesso");
        }
    }
}