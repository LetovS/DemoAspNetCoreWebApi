using System.Diagnostics.CodeAnalysis;
using Store.Entities;

namespace Repositories.Abstract.Order;

/// <summary>
/// Репозиторий чтения заказов
/// </summary>
public interface IOrderReadRepository: IDbReadRepositoryBase<OrderRecord>
{
    /// <summary>
    /// Получить заказ по номеру
    /// </summary>
    Task<OrderRecord?> GetByOrderNumber([NotNull] string orderNumber, CancellationToken ct = default);

    /// <summary>
    /// Получить заказы по ИД провайдера
    /// </summary>
    Task<IReadOnlyList<OrderRecord>> GetByProviderId(Guid providerId, CancellationToken ct = default);
}