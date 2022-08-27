using Identity4121.Infrastructure.Notification.Email;
using Identity4121.Infrastructure.Notification.Sms;
using Microsoft.Extensions.DependencyInjection;

namespace Identity4121.Infrastructure.Notification
{
    public static class NotificationServiceCollectionExtensions
    {
        public static IServiceCollection AddNotificationServices(this IServiceCollection services, NotificationOptions options)
        {
            services.AddEmailNotification(options.Email);

            services.AddSmsNotification(options.Sms);

            return services;
        }
    }
}
