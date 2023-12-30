using AutoMapper;
using Business.Abstract.Models;
using Business.Abstract.Services;
using Business.Models.Provider;
using Microsoft.AspNetCore.Mvc;
using Store.Abstract.Entity;
using Web.Api.Validators;
using Web.Contracts.Abstract;
using Web.Contracts.Models;
using Web.Contracts.Models.Provider;

namespace Web.Api.Controllers.Base;

/// <summary>
/// Базовый контроллер ресурсов
/// </summary>
[ApiController]
[ApiExplorerSettings(GroupName = ControllerGroups.ResourcesGroup)]
public abstract class BaseController<TEntity, TCreateModel, TUpdateModel> : ControllerBase
    where TEntity : class, IEntityWithId
    where TCreateModel : ICreateModel
    where TUpdateModel : class, IUpdateModel
{
    private readonly IBusinessService<TEntity, TCreateModel, TUpdateModel> _service;
    private readonly IMapper _mapper;

    /// <summary>
    /// ctor.
    /// </summary>
    protected BaseController(
        IBusinessService<TEntity, TCreateModel, TUpdateModel> service,
        IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Получить сущность по ИД
    /// </summary>
    [HttpGet("{id:guid}",Name = "GetById")]
    public async Task<IActionResult> GetById([FromRoute, NotDefaultGuid] Guid id, CancellationToken ct)
    {
        var response = await _service.GetByIdAsync(id, ct);
        return Ok(response);
    }

    /// <summary>
    /// Получить всех сущности
    /// </summary>
    [HttpGet(Name = "GetAll")]
    public async Task<GetAllResponse<IResponse>> GetAll(
        [FromQuery]PaginationFilter paginationFilter,
        CancellationToken ct)
    {
        var response = await _service.GetAll(paginationFilter.Offset, paginationFilter.Offset, ct);
        var data = _mapper.Map<List<ProviderResponse>>(response.Data);
        return new GetAllResponse<IResponse>(data, response.Count);
    } 
    
    /// <summary>
    /// Создать сущность
    /// </summary> 
    /// <response code="200">Данные получены</response>
    /// <response code="400">Ошибка валидации входных данных</response>
    [HttpPost("{id:guid}",Name = "Create")]
    public async Task<IActionResult> Create(
        [FromRoute, NotDefaultGuid] Guid id,
        ICreateModelRequest request,
        CancellationToken ct)
    {
        var mappedProvider = _mapper.Map<TCreateModel>(request);

        var created = await _service.CreateAsync(id, mappedProvider, ct);

        return Ok(created);
    }

    /// <summary>
    /// Обновить сущность
    /// </summary>
    [HttpPut("{id:guid}", Name = "Update")]
    public async Task<IActionResult> Update(
        [FromRoute, NotDefaultGuid] Guid id,
        IUpdateModelRequest request,
        CancellationToken ct)
    {
        var createModel = _mapper.Map<TUpdateModel>(request);
        var result = await _service.UpdateAsync(id, createModel, ct);
        
        return result ? Ok() : Problem();
    }

    /// <summary>
    /// Удалить сущность
    /// </summary>
    [HttpDelete("{id:guid}", Name = "Delete")]
    public async Task<IActionResult> Delete([FromRoute, NotDefaultGuid] Guid id,CancellationToken ct)
    {
        var result = await _service.DeleteAsync(id, ct);
        
        return result ? Ok() : Problem();
    }
}