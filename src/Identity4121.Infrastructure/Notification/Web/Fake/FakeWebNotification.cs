﻿namespace Identity4121.Infrastructure.Notification.Web.Fake
{
    public class FakeWebNotification<T> : IWebNotification<T>
    {
        public Task SendAsync(T message, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
