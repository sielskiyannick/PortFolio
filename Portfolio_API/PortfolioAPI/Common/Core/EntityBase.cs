namespace Common.Core
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; set; }
    }
}
