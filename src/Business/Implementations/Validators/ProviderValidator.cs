using Business.Abstract;
using Repositories.Abstract.Order;
using Repositories.Abstract.Provider;
using Store.Entities;

namespace Business.Implementations.Validators;

/// <summary>
/// Валидатор провайдера
/// </summary>
public class ProviderValidator : ValidatorBase<ProviderRecord>
{
    private readonly IProviderReadRepository _readProviderRepository;
    private readonly IOrderReadRepository _readOrderRepository;

    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderValidator(
        IProviderReadRepository readProviderRepository,
        IOrderReadRepository readOrderRepository)
    {
        _readProviderRepository = readProviderRepository;
        _readOrderRepository = readOrderRepository;
    }

    /// <inheritdoc/>
    public override async Task ValidateSave(ProviderRecord entity, CancellationToken ct)
    {
        var entityById = await _readProviderRepository.GetById(entity.Id, ct);
        
        var entityByName = await _readProviderRepository.GetByName(entity.ProviderName!, ct);

        if (entityById != null && entityByName != null)
        {
            throw new ArgumentException("Сохранить нельзя");
        }
    }

    /// <inheritdoc/>
    public override async Task ValidateDelete(Guid entityId, CancellationToken ct)
    {
        var entityById = await _readProviderRepository.GetById(entityId, ct) ?? throw new ArgumentException();
        
        var orders = await _readOrderRepository.GetByProviderId(entityId, ct);
        if (orders.Any())
        {
            throw new ArgumentException("Удалить нельзя");
        }
    }
}