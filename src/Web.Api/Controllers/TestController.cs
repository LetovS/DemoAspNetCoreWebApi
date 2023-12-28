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

    /// <summary>
    /// Получить всех провайдеров
    /// </summary>
    [HttpGet("Gets", Name = "Get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var all = await service.GetAll();
        return Ok(all.Data);
    }
}
