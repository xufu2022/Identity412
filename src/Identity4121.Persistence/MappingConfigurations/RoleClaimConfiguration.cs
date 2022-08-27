namespace Identity4121.Persistence.MappingConfigurations
{
    public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            builder.ToTable("RoleClaims");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
