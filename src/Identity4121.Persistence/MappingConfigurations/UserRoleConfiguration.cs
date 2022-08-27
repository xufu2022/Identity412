namespace Identity4121.Persistence.MappingConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
