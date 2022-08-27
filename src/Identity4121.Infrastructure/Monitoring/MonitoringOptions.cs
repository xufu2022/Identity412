using Identity4121.Infrastructure.Monitoring.AppMetrics;
using Identity4121.Infrastructure.Monitoring.AzureApplicationInsights;
using Identity4121.Infrastructure.Monitoring.MiniProfiler;

namespace Identity4121.Infrastructure.Monitoring
{
    public class MonitoringOptions
    {
        public MiniProfilerOptions MiniProfiler { get; set; }

        public AzureApplicationInsightsOptions AzureApplicationInsights { get; set; }

        public AppMetricsOptions AppMetrics { get; set; }
    }
}
