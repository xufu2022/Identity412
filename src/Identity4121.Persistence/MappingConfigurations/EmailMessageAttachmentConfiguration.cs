namespace Identity4121.Persistence.MappingConfigurations
{
    public class EmailMessageAttachmentConfiguration : IEntityTypeConfiguration<EmailMessageAttachment>
    {
        public void Configure(EntityTypeBuilder<EmailMessageAttachment> builder)
        {
            builder.ToTable("EmailMessageAttachments");
            builder.Property(x => x.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
