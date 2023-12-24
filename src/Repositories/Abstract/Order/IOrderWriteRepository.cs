using Store.Entities;

namespace Repositories.Abstract.Order;

/// <summary>
/// Репозиторий записи заказов
/// </summary>
public interface IOrderWriteRepository : IDbWriteRepositoryBase<OrderRecord>
{
    
}