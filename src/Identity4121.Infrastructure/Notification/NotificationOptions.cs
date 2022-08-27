using Identity4121.Infrastructure.Notification.Email;
using Identity4121.Infrastructure.Notification.Sms;
using Identity4121.Infrastructure.Notification.Web;

namespace Identity4121.Infrastructure.Notification
{
    public class NotificationOptions
    {
        public EmailOptions Email { get; set; }

        public SmsOptions Sms { get; set; }

        public WebOptions Web { get; set; }
    }
}
