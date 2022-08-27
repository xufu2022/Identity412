namespace Identity4121.Infrastructure.Notification.Web.SignalR
{
    public class SignalROptions
    {
        public string Endpoint { get; set; }

        public Dictionary<string, string> Hubs { get; set; }

        public Dictionary<string, string> MethodNames { get; set; }
    }
}
