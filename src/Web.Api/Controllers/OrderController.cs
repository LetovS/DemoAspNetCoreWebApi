using AutoMapper;
using Business.Abstract.Services;
using Business.Models.Order;
using Microsoft.AspNetCore.Mvc;
using Store.Entities;
using Web.Api.Controllers.Base;
using Web.Api.Validators;
using Web.Contracts.Models;
using Web.Contracts.Models.Order;

namespace Web.Api.Controllers;

/// <summary>
/// Контроллер заказаов
/// </summary>
[ApiController]
[Route("api/v1/orders")]
public sealed class OrderController : BaseController<OrderRecord, CreateOrderModel, UpdateOrderModel>//ControllerBase
{


    //private readonly IOrderService _orderService;
    //private readonly IMapper _mapper;

    ///// <summary>
    ///// ctor.
    ///// </summary>
    //public OrderController(IOrderService orderService, IMapper mapper)
    //{
    //    _orderService = orderService;
    //    _mapper = mapper;
    //}

    ///// <summary>
    ///// Получить заказ по ИД
    ///// </summary>
    //[HttpGet("{id:guid}",Name = "GetOrderById")]
    //public async Task<IActionResult> GetById([FromRoute, NotDefaultGuid] Guid id, CancellationToken ct)
    //{
    //    var order = await _orderService.GetByIdAsync(id, ct);
    //    return Ok(order);
    //}

    ///// <summary>
    ///// Получить все заказы
    ///// </summary>
    //[HttpGet(Name = "GetAllOrders")]
    //public async Task<GetAllResponse<OrderResponse>> GetAll(
    //    [FromQuery]PaginationFilter paginationFilter,
    //    CancellationToken ct)
    //{
    //    var response = await _orderService.GetAll(paginationFilter.Offset, paginationFilter.Offset, ct);
    //    var data = _mapper.Map<List<OrderResponse>>(response.Data);
    //    return new GetAllResponse<OrderResponse>(data, response.Count);
    //} 

    ///// <summary>
    ///// Создать заказ
    ///// </summary> 
    ///// <response code="200">Данные получены</response>
    ///// <response code="400">Ошибка валидации входных данных</response>
    //[HttpPost("{id:guid}",Name = "CreateOrder")]
    //public async Task<IActionResult> Create(
    //    [FromRoute, NotDefaultGuid] Guid id,
    //    CreateOrderRequest request,
    //    CancellationToken ct)
    //{
    //    var createOrder = _mapper.Map<CreateOrderModel>(request);

    //    var created = await _orderService.CreateAsync(id, createOrder, ct);

    //    return Ok(created);
    //}

    ///// <summary>
    ///// Обновить заказ
    ///// </summary>
    //[HttpPut("{id:guid}", Name = "UpdateOrder")]
    //public async Task<IActionResult> Update(
    //    [FromRoute, NotDefaultGuid] Guid id,
    //    UpdateOrderRequest request,
    //    CancellationToken ct)
    //{
    //    var createModel = _mapper.Map<UpdateOrderModel>(request);
    //    var result = await _orderService.UpdateAsync(id, createModel, ct);

    //    return result ? Ok() : Problem();
    //}

    ///// <summary>
    ///// Удалить заказ
    ///// </summary>
    //[HttpDelete("{id:guid}", Name = "DeleteOrder")]
    //public async Task<IActionResult> Delete([FromRoute, NotDefaultGuid] Guid id,CancellationToken ct)
    //{
    //    var result = await _orderService.DeleteAsync(id, ct);

    //    return result ? Ok() : Problem();
    //}
    public OrderController(IBusinessService<OrderRecord, CreateOrderModel, UpdateOrderModel> service, IMapper mapper) : base(service, mapper)
    {
    }
}