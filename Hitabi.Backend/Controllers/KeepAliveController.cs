using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hitabi.Backend;

[Route("/api/v1/keep-alives")]
public class KeepAliveController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public IActionResult GetKeepAlive()
    {
        return Ok();
    }

    [Authorize]
    [HttpGet]
    [Route("auth")]
    public IActionResult GetKeepAliveWithAuth()
    {
        return Ok();
    }
}
