using AutoMapper;
using Business.Abstract.Services;
using Business.Models.OrderItem;
using Microsoft.AspNetCore.Mvc;
using Store.Entities;
using Web.Api.Controllers.Base;
using Web.Api.Validators;
using Web.Contracts.Models;
using Web.Contracts.Models.OrderItem;

namespace Web.Api.Controllers;

/// <summary>
/// Контроллер содержимого заказа
/// </summary>
[ApiController]
[Route("api/v1/order-items")]
public class OrderItemController : BaseController<OrderItemRecord, CreateOrderItemModel, UpdateOrderItemModel>//ControllerBase
{





    //private readonly IOrderItemService _orderItemService;
    //private readonly IMapper _mapper;

    ///// <summary>
    ///// ctor.
    ///// </summary>
    //public OrderItemController(IOrderItemService orderItemService, IMapper mapper)
    //{
    //    _orderItemService = orderItemService;
    //    _mapper = mapper;
    //}

    ///// <summary>
    ///// Получить позицию заказа по ИД
    ///// </summary>
    //[HttpGet("{id:guid}", Name = "GetOrderItemById")]
    //public async Task<IActionResult> GetById([FromRoute, NotDefaultGuid] Guid id, CancellationToken ct)
    //{
    //    var orderItem = await _orderItemService.GetByIdAsync(id, ct);
    //    return Ok(orderItem);
    //}

    ///// <summary>
    ///// Получить все позиция заказа
    ///// </summary>
    //[HttpGet(Name = "GetAllOrderItems")]
    //public async Task<GetAllResponse<OrderItemResponse>> GetAll(
    //    [FromQuery] PaginationFilter paginationFilter,
    //    CancellationToken ct)
    //{
    //    var response = await _orderItemService.GetAll(paginationFilter.Offset, paginationFilter.Offset, ct);
    //    var data = _mapper.Map<List<OrderItemResponse>>(response.Data);
    //    return new GetAllResponse<OrderItemResponse>(data, response.Count);
    //}

    ///// <summary>
    ///// Создать новую позицию заказа
    ///// </summary> 
    ///// <response code="200">Данные получены</response>
    ///// <response code="400">Ошибка валидации входных данных</response>
    //[HttpPost("{id:guid}", Name = "CreateOrderItem")]
    //public async Task<IActionResult> Create(
    //    [FromRoute, NotDefaultGuid] Guid id,
    //    CreateOrderItemRequest request,
    //    CancellationToken ct)
    //{
    //    var createOrder = _mapper.Map<CreateOrderItemModel>(request);

    //    var created = await _orderItemService.CreateAsync(id, createOrder, ct);

    //    return Ok(created);
    //}

    ///// <summary>
    ///// Обновить позицию заказа
    ///// </summary>
    //[HttpPut("{id:guid}", Name = "UpdateOrderItem")]
    //public async Task<IActionResult> Update(
    //    [FromRoute, NotDefaultGuid] Guid id,
    //    UpdateOrderItemRequest request,
    //    CancellationToken ct)
    //{
    //    var updateModel = _mapper.Map<UpdateOrderItemModel>(request);
    //    var result = await _orderItemService.UpdateAsync(id, updateModel, ct);

    //    return result ? Ok() : Problem();
    //}

    ///// <summary>
    ///// Удалить позицию заказа
    ///// </summary>
    //[HttpDelete("{id:guid}", Name = "DeleteOrderItem")]
    //public async Task<IActionResult> Delete(
    //    [FromRoute, NotDefaultGuid] Guid id,
    //    CancellationToken ct)
    //{
    //    var result = await _orderItemService.DeleteAsync(id, ct);

    //    return result ? Ok() : Problem();
    //}
    
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemController(IBusinessService<OrderItemRecord, CreateOrderItemModel, UpdateOrderItemModel> service, IMapper mapper) : base(service, mapper)
    {
    }
}