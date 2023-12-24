using AutoMapper;
using Business.Abstract;
using Business.Abstract.Services;
using Business.Models.Order;
using Repositories.Abstract;
using Repositories.Abstract.Order;
using Store.Abstract.Context;
using Store.Entities;

namespace Business.Implementations.Services;

/// <summary>
/// Сервис заказов
/// </summary>
public class OrderService :
    BusinessServiceBase<OrderRecord, CreateOrderModel, UpdateOrderModel>,
    IOrderService
{
    private readonly IOrderReadRepository _readRepository;
    private readonly IEntityFactory _factory;

    /// <summary>
    /// ctor.
    /// </summary>
    public OrderService(
        IOrderReadRepository readRepository,
        IOrderWriteRepository writeRepository,
        IDbUnitOfWork unitOfWork,
        IBusinessValidator<OrderRecord> businessValidator,
        IChangeDetector<OrderRecord, UpdateOrderModel> changeDetector,
        IMapper mapper,
        IEntityFactory factory)
        : base(readRepository, writeRepository, unitOfWork, businessValidator, changeDetector, mapper)
    {
        _readRepository = readRepository;
        _factory = factory;
    }

    /// <inheritdoc/>
    protected override OrderRecord CreateNewEntity(Guid? id, CreateOrderModel model)
    {
        return _factory.CreateNewOrder(id, model.OrderNumber, model.OrderDate, model.ProviderId);
    }

    /// <inheritdoc/>
    public Task<IReadOnlyList<OrderRecord>> GetAllByProviderId(Guid providerId, CancellationToken ct)
    {
        return _readRepository.GetByProviderId(providerId, ct);
    }

    /// <inheritdoc/>
    public async Task<OrderRecord?> GetByNumber(string number, CancellationToken ct)
    {
        return await _readRepository.GetByOrderNumber(number, ct);
    }
}