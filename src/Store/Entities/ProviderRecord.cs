using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Поставщик
/// </summary>
public class ProviderRecord : EntityBase
{
    public ProviderRecord(
        Guid id) : base(id)
    {
    }
    
    /// <summary>
    /// Название поставщика
    /// </summary>
    public string? ProviderName { get; set; }    

    public virtual List<OrderRecord> Orders { get; set; } = new List<OrderRecord>();
}