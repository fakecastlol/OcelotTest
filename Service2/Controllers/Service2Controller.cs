using Microsoft.AspNetCore.Mvc;

namespace Service2.Controllers
{
    [Route("")]
    [ApiController]
    public class Service2Controller : ControllerBase
    {
        [HttpGet("service2")]
        public string Get()
        {
            return "This is the 2nd service.";
        }
    }
}
