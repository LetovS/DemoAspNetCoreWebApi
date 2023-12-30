using Web.Contracts.Abstract;

namespace Web.Contracts.Models.Order;

/// <summary>
/// Модель запроса обнавления заказа
/// </summary>
public sealed class UpdateOrderRequest : IUpdateModelRequest
{
    /// <summary>
    /// Номер заказа
    /// </summary>
    public string? OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateTime? OrderDate { get; set; }

    /// <summary>
    /// ИД поставщика
    /// </summary>
    public Guid? ProviderId { get; set; }
}