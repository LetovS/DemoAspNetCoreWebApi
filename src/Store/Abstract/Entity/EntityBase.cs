namespace Store.Abstract.Entity;

public abstract class EntityBase : IEntityWithId
{
    protected EntityBase(Guid id)
    {
        Id = id;
    }
    
    public Guid Id { get; set; }
}