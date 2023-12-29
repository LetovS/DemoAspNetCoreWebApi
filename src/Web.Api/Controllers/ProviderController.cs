using AutoMapper;
using Business.Abstract.Services;
using Business.Models.Provider;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Validators;
using Web.Contracts.Models;
using Web.Contracts.Models.Provider;

namespace Web.Api.Controllers;

/// <summary>
/// Контроллер провайдеров
/// </summary>
[ApiController]
[Route("api/v1/providers")]
public sealed class ProviderController : ControllerBase
{
    private readonly IProviderService _serviceProvider;
    private readonly IMapper _mapper;

    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderController(IProviderService serviceProvider, IMapper mapper)
    {
        _serviceProvider = serviceProvider;
        _mapper = mapper;
    }

    /// <summary>
    /// Получить провайдера по ИД
    /// </summary>
    [HttpGet("{id:guid}",Name = "GetById")]
    public async Task<IActionResult> GetById([FromRoute, NotDefaultGuid] Guid id, CancellationToken ct)
    {
        var provider = await _serviceProvider.GetByIdAsync(id, ct);
        return Ok(provider);
    }

    /// <summary>
    /// Получить всех провайдеров
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<GetAllResponse<ProviderResponse>> GetAll(
        [FromQuery]PaginationFilter paginationFilter,
        CancellationToken ct)
    {
        var response = await _serviceProvider.GetAll(paginationFilter.Offset, paginationFilter.Offset, ct);
        var data = _mapper.Map<List<ProviderResponse>>(response.Data);
        return new GetAllResponse<ProviderResponse>(data, response.Count);
    } 
    
    /// <summary>
    /// Создание провайдера
    /// </summary> 
    /// <response code="200">Данные получены</response>
    /// <response code="400">Ошибка валидации входных данных</response>
    [HttpPost("{id:guid}",Name = "Create")]
    public async Task<IActionResult> Create(
        [FromRoute, NotDefaultGuid] Guid id,
        CreateProviderRequest request,
        CancellationToken ct)
    {
        var mappedProvider = _mapper.Map<CreateProviderModel>(request);

        var created = await _serviceProvider.CreateAsync(id, mappedProvider, ct);

        return Ok(created);
    }
}
