using Microsoft.AspNetCore.Mvc;

namespace Sample.AspNetCoreIssue.JwtBearerKeyRetrieve.Controllers;

[ApiController]
public class DiscoveryController : ControllerBase
{
    public DiscoveryController()
    {
    }

    [HttpGet("/.well-known/openid-configuration")]
    public IActionResult Index()
    {
        Console.WriteLine("/.well-known/openid-configuration endpoint called.");
        return Ok();
    }
}
