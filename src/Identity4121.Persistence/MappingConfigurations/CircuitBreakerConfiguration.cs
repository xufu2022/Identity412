using Identity4121.Persistence.CircuitBreakers;

namespace Identity4121.Persistence.MappingConfigurations
{
    public class CircuitBreakerConfiguration : IEntityTypeConfiguration<CircuitBreaker>
    {
        public void Configure(EntityTypeBuilder<CircuitBreaker> builder)
        {
            builder.ToTable("CircuitBreakers");
            builder.HasIndex(x => new { x.Name }).IsUnique();
        }
    }
}
