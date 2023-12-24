using AutoMapper;
using Business.Abstract.Models;
using Business.Abstract.Services;
using Business.Models;
using Repositories.Abstract;
using Store.Abstract.Context;
using Store.Abstract.Entity;

namespace Business.Abstract;

/// <summary>
/// Базовый сервис
/// </summary>
/// <typeparam name="TEntity">Модель БД</typeparam>
/// <typeparam name="TCreateModel">Модель создания новой сущности</typeparam>
/// <typeparam name="TUpdateModel">Модель обновления сущности</typeparam>
public abstract class BusinessServiceBase<TEntity, TCreateModel, TUpdateModel> : IBusinessService<TEntity, TCreateModel, TUpdateModel>
    where TEntity : class, IEntityWithId
    where TCreateModel : ICreateModel
    where TUpdateModel : class, IUpdateModel
{
    /// <summary>
    /// Репозиторий чтения из БД
    /// </summary>
    protected readonly IDbReadRepositoryBase<TEntity> ReadRepository;
    
    /// <summary>
    /// Репозиторий записи в БД
    /// </summary>
    protected readonly IDbWriteRepositoryBase<TEntity> WriteRepository;
    
    /// <summary>
    /// Юнит сохранения изменений в БД
    /// </summary>
    protected readonly IDbUnitOfWork UnitOfWork;
    
    /// <summary>
    /// Репозиторий чтения БД
    /// </summary>
    protected readonly IBusinessValidator<TEntity> BusinessValidator;
    
    /// <summary>
    /// Детектор изменений в сущностий
    /// </summary>
    protected readonly IChangeDetector<TEntity, TUpdateModel> ChangeDetector;

    /// <summary>
    /// Маппер
    /// </summary>
    protected readonly IMapper Mapper;

    /// <summary>
    /// ctor.
    /// </summary>
    protected BusinessServiceBase(
        IDbReadRepositoryBase<TEntity> readRepository,
        IDbWriteRepositoryBase<TEntity> writeRepository,
        IDbUnitOfWork unitOfWork,
        IBusinessValidator<TEntity> businessValidator,
        IChangeDetector<TEntity, TUpdateModel> changeDetector,
        IMapper mapper)
    {
        ReadRepository = readRepository;
        WriteRepository = writeRepository;
        UnitOfWork = unitOfWork;
        BusinessValidator = businessValidator;
        ChangeDetector = changeDetector;
        Mapper = mapper;
    }

    /// <summary>
    /// Получить по ИД
    /// </summary>
    public async Task<TEntity?> GetByIdAsync(Guid id, CancellationToken ct)
    {
        return await ReadRepository.GetById(id, ct);
    }

    /// <summary>
    /// Получить все сущности
    /// </summary>
    /// <param name="offset">Пропускаемое число записей</param>
    /// <param name="limit">Сколько берем</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<ResourceGetModel<TEntity>> GetAll(int offset = 0, int limit = 100, CancellationToken ct = default)
    {
        var (count, data) = await ReadRepository.GetAll(offset, limit, ct);

        return new ResourceGetModel<TEntity>(data: data, count: count);
    }

    /// <summary>
    /// Создать сущность
    /// </summary>
    public async Task<Guid> CreateAsync(Guid id, TCreateModel model, CancellationToken ct)
    {
        var createdEntity = CreateNewEntity(id, model);
        
        Mapper.Map(model, createdEntity);
        
        // если сохранить нельзя, бросит исключение
        await BusinessValidator.ValidateSave(createdEntity, ct);
        
        WriteRepository.Add(createdEntity);
        
        await UnitOfWork.SaveChangesAsync(ct);
        
        // обсуждаемо
        return createdEntity.Id;
    }

    /// <summary>
    /// Обновить модель
    /// </summary>
    public async Task<bool> UpdateAsync(Guid id, TUpdateModel model, CancellationToken ct)
    {
        var entity = await ReadRepository.GetById(id, ct);
        
        if (entity is null)
        {
            return false;
        }

        // true изменений нет
        if (ChangeDetector.HasNoChanges(entity, model))
        {
            throw new ArgumentException("Изменений нет");
        }

        Mapper.Map(model, entity);

        await BusinessValidator.ValidateSave(entity, ct);
        
        WriteRepository.Update(entity);
        
        await UnitOfWork.SaveChangesAsync(ct);
        
        return true;
    }

    /// <summary>
    /// Удалить по ИД
    /// </summary>
    public async Task<bool> DeleteAsync(Guid id, CancellationToken ct)
    {
        var entity = await ReadRepository.GetById(id, ct);

        if (entity is null)
        {
            return false;
        }

        // если удалить нельзя, бросит исключение
        await BusinessValidator.ValidateDelete(id, ct);

        WriteRepository.Delete(entity);
        
        await UnitOfWork.SaveChangesAsync(ct);
        
        return true;
    }

    /// <summary>
    /// Создание новой сущности
    /// </summary>
    /// <param name="id">ИД</param>
    /// <param name="model">Модель создания сущности</param>
    protected abstract TEntity CreateNewEntity(Guid? id, TCreateModel model);
}