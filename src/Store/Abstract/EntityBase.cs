namespace Store.Abstract;

public abstract class EntityBase : IEntityWithId
{
    protected EntityBase(Guid id)
    {
        Id = id;
    }
    
    public Guid Id { get; set; }
}