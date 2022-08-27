﻿namespace Identity4121.Persistence.MappingConfigurations
{
    public class LockConfiguration : IEntityTypeConfiguration<Lock>
    {
        public void Configure(EntityTypeBuilder<Lock> builder)
        {
            builder.ToTable("Locks");
            builder.HasKey(x => new { x.EntityId, x.EntityName });
            builder.HasIndex(x => new { x.OwnerId });
        }
    }
}
