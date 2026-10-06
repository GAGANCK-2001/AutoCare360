using Microsoft.AspNetCore.Mvc;

namespace AutoCare360.Api.Controllers;

[ApiController]
[Route("api/v1/health")]
public sealed class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
        => Ok(new
        {
            status = "healthy",
            service = "AutoCare360.Api",
            timestampUtc = DateTime.UtcNow
        });
}
