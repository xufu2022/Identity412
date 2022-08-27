namespace Identity4121.Domain.Entities
{
    public class DistributedTransactionProperty : Entity<Guid>
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public Guid DistributedTransactionId { get; set; }
    }
}
