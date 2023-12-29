using Business.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers;

/// <summary>
/// Контроллер заказаов
/// </summary>
[ApiController]
[Route("api/v1/orders")]
public sealed class OrderController : ControllerBase
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderController(IOrderService orderService)
    {
        
    }
}