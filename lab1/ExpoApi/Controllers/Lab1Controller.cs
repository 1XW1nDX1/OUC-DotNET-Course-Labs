using Microsoft.AspNetCore.Mvc;

namespace ExpoApi.Controllers
{
    [ApiController]
    [Route("lab1")]
    public class Lab1Controller : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Content("EXPO-READY|25030021018|海洋科技", "text/plain", contentEncoding:System.Text.Encoding.UTF8);
        }

    }
}
