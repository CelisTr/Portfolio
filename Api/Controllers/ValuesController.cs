using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("IsWorking")]
        public ActionResult IsWorking()
        {
            return Ok("Yes");
        }

    }
}