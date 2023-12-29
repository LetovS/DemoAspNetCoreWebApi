using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Поставщик
/// </summary>
public class ProviderRecord : EntityBase
{
    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderRecord(
        Guid id, string providerName) : base(id)
    {
        ProviderName = providerName;
    }
    
    /// <summary>
    /// Название поставщика
    /// </summary>
    public string ProviderName { get; set; }    

    /// <summary>
    /// Заказы
    /// </summary>
    public virtual List<OrderRecord> Orders { get; set; } = new List<OrderRecord>();
}