// Recam.Api/Controllers/TestController.cs（測試用，之後會刪掉）
using Microsoft.AspNetCore.Mvc;

namespace Recam.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("error")]
    public IActionResult ThrowError()
    {
        throw new Exception("故意出錯");
    }
}