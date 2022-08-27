namespace Identity4121.Persistence.MappingConfigurations
{
    public class SmsMessageConfiguration : IEntityTypeConfiguration<SmsMessage>
    {
        public void Configure(EntityTypeBuilder<SmsMessage> builder)
        {
            builder.ToTable("SmsMessages");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
