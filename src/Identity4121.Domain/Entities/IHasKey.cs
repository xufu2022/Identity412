namespace Identity4121.Domain.Entities
{
    public interface IHasKey<T>
    {
        T Id { get; set; }
    }
}
