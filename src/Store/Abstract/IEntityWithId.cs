namespace Store.Abstract;

public interface IEntityWithId
{
    /// <summary>
    /// Entity's identificator
    /// </summary>
    public Guid Id { get; set; }
}