namespace Identity4121.Persistence.MappingConfigurations
{
    public class DistributedTransactionPropertyConfiguration : IEntityTypeConfiguration<DistributedTransactionProperty>
    {
        public void Configure(EntityTypeBuilder<DistributedTransactionProperty> builder)
        {
            builder.ToTable("DistributedTransactionProperties");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
