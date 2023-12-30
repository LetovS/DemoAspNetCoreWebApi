using Web.Contracts.Abstract;
using Web.Contracts.Models.OrderItem;

namespace Web.Contracts.Models.Order;

/// <summary>
/// Модель ответа заказа
/// </summary>
public sealed class OrderResponse : IResponse
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderResponse(
        Guid id,
        string orderNumber,
        DateTime orderDate,
        Guid providerId)
    {
        Id = id;
        OrderNumber = orderNumber;
        OrderDate = orderDate;
        ProviderId = providerId;
    }
    
    /// <summary>
    /// ИД заказа
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Номер заказа
    /// </summary>
    public string OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// ИД поставщика
    /// </summary>
    public Guid ProviderId { get; set; }

    /// <summary>
    /// Содержимое заказа
    /// </summary>
    public IReadOnlyList<OrderItemResponse> OrderItems { get; set; } = new List<OrderItemResponse>();
}