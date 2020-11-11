using Microsoft.AspNetCore.Mvc;

namespace Service1.Controllers
{
    [Route("")]
    [ApiController]
    public class Service1Controller : ControllerBase
    {
        [HttpGet("service1")]
        public string Get()
        {
            return "This is the 1st service.";
        }
    }
}
