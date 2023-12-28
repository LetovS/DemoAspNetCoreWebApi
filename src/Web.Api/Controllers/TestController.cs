using Business.Abstract.Services;
using Microsoft.AspNetCore.Mvc;
using Web.Contracts.Models.Provider;

namespace Web.Api.Controllers;

/// <summary>
/// Тестовый контроллер
/// </summary>

[ApiController]
[Route("api/v1/tests")]
public class TestController : ControllerBase
{
    private readonly IProviderService service;

    /// <summary>
    /// ctor.
    /// </summary>
    public TestController(IProviderService service)
    {
        this.service = service;
    }


    [HttpGet("Gets", Name = "Get")]
    public async Task<IActionResult> GetAsync()
    {        
        return Ok(new ProviderResponse(Guid.NewGuid(), "Test"));
    }
}
