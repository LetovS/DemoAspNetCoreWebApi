using AutoMapper;
using Business.Abstract;
using Business.Abstract.Services;
using Business.Models.Provider;
using Repositories.Abstract;
using Repositories.Abstract.Provider;
using Store.Abstract.Context;
using Store.Entities;

namespace Business.Implementations.Services;

/// <summary>
/// Сервис провайдеров
/// </summary>
public class ProviderService :
    BusinessServiceBase<ProviderRecord, CreateProviderModel, UpdateProviderModel>,
    IProviderService
{
    private readonly IProviderReadRepository _readRepository;
    private readonly IEntityFactory _factory;

    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderService(
        IProviderReadRepository readRepository,
        IProviderWriteRepository writeRepository,
        IDbUnitOfWork unitOfWork,
        IBusinessValidator<ProviderRecord> businessValidator,
        IChangeDetector<ProviderRecord, UpdateProviderModel> changeDetector,
        IMapper mapper,
        IEntityFactory factory
        ) : base(readRepository, writeRepository, unitOfWork, businessValidator, changeDetector, mapper)
    {
        _readRepository = readRepository;
        _factory = factory;
    }

    /// <inheritdoc/>
    public async Task<ProviderRecord?> GetByName(string name, CancellationToken ct)
    {
        return await _readRepository.GetByName(name, ct);
    }

    /// <inheritdoc/>
    protected override ProviderRecord CreateNewEntity(Guid? id, CreateProviderModel model)
    {
        return _factory.CreateNewProvider(id, model.Name);
    }
}