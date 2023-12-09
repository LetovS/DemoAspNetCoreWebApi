using Store.Abstract;

namespace Store.Entities;

/// <summary>
/// Поставщик
/// </summary>
public class ProviderRecord : EntityBase
{
    public ProviderRecord(Guid id) : base(id)
    {
    }
    
    /// <summary>
    /// Название поставщика
    /// </summary>
    public string ProviderName { get; set; }
    
    /// <summary>
    /// Все заказы поставщика
    /// </summary>
    public virtual ICollection<OrderRecord> Orders { get; set; }
}