using Microsoft.AspNetCore.Mvc;

namespace Slack.Json.Controllers
{
    public class HealthController: Controller
    {
        [HttpGet("/healtz")]
        public IActionResult HealtCheck()
        {
            return Ok(new {});
        }

        // Google ingress requires root to return ok code.
        [HttpGet("/")]
        public IActionResult RootCheck()
        {
            return Ok(new {});
        }
    }
}