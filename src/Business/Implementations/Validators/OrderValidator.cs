using Business.Abstract;
using Repositories.Abstract.Order;
using Repositories.Abstract.OrderItem;
using Store.Entities;

namespace Business.Implementations.Validators;

/// <summary>
/// Валидатор заказа
/// </summary>
public class OrderValidator : ValidatorBase<OrderRecord>
{
    private readonly IOrderReadRepository _readOrderRepository;
    private readonly IOrderItemReadRepository _readOrderItemRepository;

    /// <summary>
    /// ctor.
    /// </summary>
    public OrderValidator(
        IOrderReadRepository readOrderRepository,
        IOrderItemReadRepository readOrderItemRepository)
    {
        _readOrderRepository = readOrderRepository;
        _readOrderItemRepository = readOrderItemRepository;
    }

    /// <inheritdoc/>
    public override async Task ValidateSave(OrderRecord entity, CancellationToken ct)
    {
        var entityById = await _readOrderRepository.GetById(entity.Id, ct);
        
        var entityByName = await _readOrderRepository.GetByOrderNumber(entity.OrderNumber!, ct);

        if (entityById != null && entityByName != null)
        {
            throw new ArgumentException();
        }
    }

    /// <inheritdoc/>
    public override async Task ValidateDelete(Guid entityId, CancellationToken ct)
    {
        var entityById = await _readOrderRepository.GetById(entityId, ct) ?? throw new ArgumentException();
        
        var orders = await _readOrderItemRepository.GetByOrderId(entityId, ct);
        if (orders.Any())
        {
            throw new ArgumentException();
        }
    }
}