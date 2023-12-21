using Business.Abstract.Models;

namespace Business.Models.Order;

/// <summary>
/// Модель обновления заказа
/// </summary>
public sealed class UpdateOrderModel : IUpdateModel
{
    /// <summary>
    /// ctor.
    /// </summary>
    public UpdateOrderModel(
        string orderNumber,
        DateTime orderDate,
        Guid providerId)
    {
        OrderNumber = orderNumber;
        OrderDate = orderDate;
        ProviderId = providerId;
    }
    
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
}