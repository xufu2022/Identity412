namespace Identity4121.Persistence.MappingConfigurations
{
    public class DistributedTransactionConfiguration : IEntityTypeConfiguration<DistributedTransaction>
    {
        public void Configure(EntityTypeBuilder<DistributedTransaction> builder)
        {
            builder.ToTable("DistributedTransactions");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
