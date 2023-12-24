using AutoMapper;
using Business.Abstract;
using Business.Abstract.Services;
using Business.Models.OrderItem;
using Repositories.Abstract;
using Repositories.Abstract.OrderItem;
using Store.Abstract.Context;
using Store.Entities;

namespace Business.Implementations.Services;

/// <summary>
/// Сервис элементов заказа
/// </summary>
public class OrderItemService :
    BusinessServiceBase<OrderItemRecord, CreateOrderItemModel, UpdateOrderItemModel>,
    IOrderItemService
{
    private readonly IEntityFactory _factory;

    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemService(
        IOrderItemReadRepository readRepository,
        IOrderItemWriteRepository writeRepository,
        IDbUnitOfWork unitOfWork,
        IBusinessValidator<OrderItemRecord> businessValidator,
        IChangeDetector<OrderItemRecord, UpdateOrderItemModel> changeDetector,
        IMapper mapper,
        IEntityFactory factory)
        : base(readRepository, writeRepository, unitOfWork, businessValidator, changeDetector, mapper)
    {
        _factory = factory;
    }

    /// <inheritdoc/>
    protected override OrderItemRecord CreateNewEntity(Guid? id, CreateOrderItemModel model)
    {
        return _factory.CreateNewOrderItem(id, model.Name, model.Quantity, model.Unit, model.OrderId);
    }
}