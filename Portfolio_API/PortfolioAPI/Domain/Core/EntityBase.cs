namespace Domain.Core
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; set; }
    }
}
