using Identity4121.Persistence.CircuitBreakers;

namespace Identity4121.Persistence.MappingConfigurations
{
    public class CircuitBreakerLogConfiguration : IEntityTypeConfiguration<CircuitBreakerLog>
    {
        public void Configure(EntityTypeBuilder<CircuitBreakerLog> builder)
        {
            builder.ToTable("CircuitBreakerLogs");
        }
    }
}
