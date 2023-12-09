namespace Store.Abstract.Entity;

public interface IEntityWithId
{
    /// <summary>
    /// Entity's identificator
    /// </summary>
    public Guid Id { get; set; }
}