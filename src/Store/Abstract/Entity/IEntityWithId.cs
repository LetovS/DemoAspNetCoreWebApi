namespace Store.Abstract.Entity;

public interface IEntityWithId : IEntity
{
    /// <summary>
    /// Entity's identificator
    /// </summary>
    public Guid Id { get; set; }
}