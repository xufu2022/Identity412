namespace Identity4121.Domain.Entities
{
    public class Product : AggregateRoot<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
