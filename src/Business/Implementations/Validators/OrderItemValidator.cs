using Business.Abstract;
using Repositories.Abstract.OrderItem;
using Store.Entities;

namespace Business.Implementations.Validators;

/// <summary>
/// Валидатор товара
/// </summary>
public class OrderItemValidator : ValidatorBase<OrderItemRecord>
{
    private readonly IOrderItemReadRepository _readProviderRepository;

    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemValidator(
        IOrderItemReadRepository readProviderRepository)
    {
        _readProviderRepository = readProviderRepository;
    }

    /// <inheritdoc/>
    public override async Task ValidateSave(OrderItemRecord entity, CancellationToken ct)
    {
        var entityById = await _readProviderRepository.GetById(entity.Id, ct);
        
        var entityByName = await _readProviderRepository.GetByName(entity.Name!, ct);

        if (entityById != null && entityByName != null)
        {
            throw new ArgumentException();
        }
    }
}