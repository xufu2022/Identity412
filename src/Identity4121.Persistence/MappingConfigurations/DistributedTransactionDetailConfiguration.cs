namespace Identity4121.Persistence.MappingConfigurations
{
    public class DistributedTransactionDetailConfiguration : IEntityTypeConfiguration<DistributedTransactionDetail>
    {
        public void Configure(EntityTypeBuilder<DistributedTransactionDetail> builder)
        {
            builder.ToTable("DistributedTransactionDetails");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
