using Repositories.Abstract;
using Repositories.Abstract.Order;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Order;

/// <summary>
/// Репозиторий записи заказа
/// </summary>
public class OrderWriteRepository :
    WriteRepositoryBase<OrderRecord>,
    IOrderWriteRepository
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderWriteRepository(IDbWriter writer) : base(writer)
    {
    }
}