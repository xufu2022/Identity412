namespace Identity4121.Persistence.Repositories
{
    public class SmsMessageRepository : Repository<SmsMessage, Guid>, ISmsMessageRepository
    {
        public SmsMessageRepository(AdsDbContext dbContext,
            IDateTimeProvider dateTimeProvider)
            : base(dbContext, dateTimeProvider)
        {
        }
    }
}
