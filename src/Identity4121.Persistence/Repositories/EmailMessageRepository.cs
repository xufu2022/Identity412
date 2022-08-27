namespace Identity4121.Persistence.Repositories
{
    public class EmailMessageRepository : Repository<EmailMessage, Guid>, IEmailMessageRepository
    {
        public EmailMessageRepository(AdsDbContext dbContext,
            IDateTimeProvider dateTimeProvider)
            : base(dbContext, dateTimeProvider)
        {
        }
    }
}
