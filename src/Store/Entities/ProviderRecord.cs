using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Поставщик
/// </summary>
public class ProviderRecord : EntityBase
{
    public ProviderRecord(
        Guid id,
        string providerName) : base(id)
    {
        ProviderName = providerName;
    }
    
    /// <summary>
    /// Название поставщика
    /// </summary>
    public string ProviderName { get; set; }

    ///// <summary>
    ///// Все заказы поставщика
    ///// </summary>
    //public virtual ICollection<OrderRecord> Orders { get; set; } = new List<OrderRecord>();
}