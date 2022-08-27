namespace Identity4121.Domain.Entities
{
    public class RoleClaim : Entity<Guid>
    {
        public string Type { get; set; }
        public string Value { get; set; }

        public Role Role { get; set; }
    }
}
