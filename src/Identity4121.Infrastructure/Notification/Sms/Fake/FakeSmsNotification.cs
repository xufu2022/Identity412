namespace Identity4121.Infrastructure.Notification.Sms.Fake
{
    public class FakeSmsNotification : ISmsNotification
    {
        public Task SendAsync(ISmsMessage smsMessage, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
